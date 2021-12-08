using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Creature.Data
{
    public class Game
    {
        public Game(World world, Player player)
        {
            World = world;
            Player = player;

            Commands = new Dictionary<string, Command>()
            {
                { "DATA", new Command("DATA", new string[] { "DATA", "INFORMATION", "INFO" }, Data) },
                { "BATTLE", new Command("BATTLE", new string[] { "BATTLE", "FIGHT", "COMBAT" }, Battle) },
                { "TEAM", new Command("TEAM", new string[] { "TEAM", "PARTY", "GROUP" }, Team) },
                { "QUIT", new Command("QUIT", new string[] { "QUIT", "Q", "STOP", "END" }, Quit) },
            };
        }

        public World World { get; private set; }
        public Player Player { get; private set; }
        public Dictionary<string, Command> Commands { get; private set; }

        public bool IsGameRunning { get; set; }
        public bool IsInBattle { get; set; }

        public string StartMessage { get; set; }
        public string ExitMessage { get; set; }

        public static Game Load()
        {
            World world = new World();
            Player player = new Player();

            Game game = new Game(world, player);
            return game;
        }

        public void Run()
        {
            Console.WriteLine(string.IsNullOrWhiteSpace(StartMessage) ? "Creature RPG" : StartMessage);

            IsGameRunning = true;
            while (IsGameRunning)
            {
                if (IsInBattle)
                {
                    Console.WriteLine($"{Player.PlayerName}'s {World.Member.Name}: {World.Member.Health}/{World.Member.MaxHealth}");
                    Console.WriteLine("\tVS");
                    Console.WriteLine($"Enemy {World.Opponent.Name}: {World.Opponent.Health}/{World.Opponent.MaxHealth}");
                }

                Console.Write($"\nWhat will {Player.PlayerName} do?: ");
                string commandString = Console.ReadLine().Trim().ToUpper();
                Command foundCommand = null;
                foreach (Command command in Commands.Values)
                {
                    if (command.Verbs.Contains(commandString))
                    {
                        foundCommand = command;
                        break;
                    }
                }

                if (foundCommand != null)
                {
                    foundCommand.Action(this);
                }
                else
                {
                    Console.WriteLine("Unknown command.");
                }
            }

            Console.WriteLine(string.IsNullOrWhiteSpace(ExitMessage) ? "Thank you for playing!" : ExitMessage);
        }

        public static void Data(Game game)
        {
            int index = 0;
            foreach (Creature creature in game.World.CreatureIndex)
            {
                index++;
                Console.WriteLine($"{index}. {creature.Name}");
                Console.WriteLine($"{creature.Health}/{creature.MaxHealth}");
            }
        }

        public static void Team(Game game)
        {
            int index = 0;
            foreach (Creature creature in game.Player.Team)
            {
                index++;
                Console.WriteLine($"{index}. {creature.Name}");
                Console.WriteLine($"{creature.Health}/{creature.MaxHealth}");
            }
        }

        public static void Battle(Game game)
        {
            if (!game.IsInBattle)
            {
                Console.WriteLine("Enter battle?");
                string choiceString = "";
                while (choiceString != "YES" && choiceString != "Y" && choiceString != "NO" && choiceString != "N")
                {
                    Console.Write("Please enter Yes/No (Y/N): ");
                    choiceString = Console.ReadLine().Trim().ToUpper();
                }

                if (choiceString == "NO" && choiceString == "N")
                {
                    return;
                }
                else
                {
                    game.IsInBattle = true;
                    game.World.SpawnOpponent();
                    Console.WriteLine($"Enemy {game.World.Opponent.Name} appeared!");
                    game.World.ChooseMember(game.Player);
                }
            }
            else
            {
                game.PlayerTurn(game);
                game.EnemyTurn(game);
            }
        }

        public static void Quit(Game game)
        {
            game.IsGameRunning = false;
        }

        public void PlayerTurn(Game game)
        {
            Console.WriteLine($"What will {game.Player.PlayerName}'s {game.World.Member.Name} do?");

            int searchIndex = 0;

            while (searchIndex < 1 || searchIndex > game.World.Member.SkillSet.Count)
            {
                int index = 0;
                foreach (Skill skill in game.World.Member.SkillSet)
                {
                    index++;
                    Console.WriteLine($"{index}. {skill.Name}");
                }

                Console.WriteLine("Enter Skill Number: ");
                string searchString = Console.ReadLine();

                bool success = int.TryParse(searchString, out int number);
                if (!success)
                {
                    searchIndex = 0;
                }
                else
                {
                    searchIndex = number;
                }
            }

            Skill playerSkill = game.World.Member.SkillSet[searchIndex - 1];
            Console.WriteLine($"{game.Player.PlayerName}'s {game.World.Member.Name} used {playerSkill.Name}!");
            UseSkill(playerSkill, game.World.Opponent);
        }

        public void EnemyTurn(Game game)
        {
            Random random = new Random();
            int index = random.Next(game.World.Opponent.SkillSet.Count);

            Skill enemySkill = game.World.Opponent.SkillSet[index];
            Console.WriteLine($"Enemy {game.World.Opponent.Name} used {enemySkill.Name}!");
            UseSkill(enemySkill, game.World.Member);
        }

        public void UseSkill(Skill skill, Creature creature)
        {
            int damage;

            if (skill.Power > 0)
            {
                if (skill.Element == creature.Weakness && skill.Element != creature.Resistance)
                {
                    damage = skill.Power * 2;
                    creature.Health -= damage;
                    Console.WriteLine($"{creature.Name} took {damage} damage due to {skill.Element} Weakness!\n");
                }
                else if (skill.Element == creature.Resistance && skill.Element != creature.Weakness)
                {
                    damage = skill.Power / 2;
                    creature.Health -= damage;
                    Console.WriteLine($"{creature.Name} took {damage} damage due to {skill.Element} Resistance!\n");
                }
                else
                {
                    damage = skill.Power;
                    creature.Health -= damage;
                    Console.WriteLine($"{creature.Name} took {damage} damage!\n");
                }
            }
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            foreach (string name in Player.TeamNames)
            {
                foreach (Creature creature in World.CreatureIndex)
                {
                    if (name == creature.Name)
                    {
                        Creature playerCreature = new Creature(creature.Name, creature.MaxHealth, creature.Weakness, creature.Resistance, creature.Description);
                        playerCreature.SkillSet = creature.SkillSet;
                        Player.Team.Add(playerCreature);
                        break;
                    }
                }
            }
        }
    }
}
