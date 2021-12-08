using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Creature.Data
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Game(World world, Player player)
        {
            World = world;
            Player = player;

            Commands = new Dictionary<string, Command>()
            {
                { "DATA", new Command("DATA", new string[] { "DATA", "D", "INFORMATION", "INFO", "I" }, Data) },
                { "BATTLE", new Command("BATTLE", new string[] { "BATTLE", "B", "FIGHT", "F", "COMBAT" }, Battle) },
                { "TEAM", new Command("TEAM", new string[] { "TEAM", "T", "PARTY", "P", "GROUP" }, Team) },
                { "SWAP", new Command("SWAP", new string[] { "SWAP", "SWITCH", "EXCHANGE" }, Swap) },
                { "REST", new Command("REST", new string[] { "REST", "R", "HEAL", "RECOVER" }, Rest) },
                { "SCORE", new Command("SCORE", new string[] { "SCORE", "STAT", "STATS", "S", "PROFILE" }, Score) },
                { "QUIT", new Command("QUIT", new string[] { "QUIT", "Q", "FORFEIT", "STOP", "END", "LEAVE" }, Quit) },
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

            Console.WriteLine("\nFinal Player Statistics\n--------------------");
            Console.WriteLine($"Name: {Player.PlayerName}\nWins: {Player.Wins} ~|~ Losses: {Player.Losses} ~|~ Actions: {Player.Actions}\n");

            Console.WriteLine(string.IsNullOrWhiteSpace(ExitMessage) ? "Thank you for playing!" : ExitMessage);
        }

        public static void Data(Game game)
        {
            // If in battle, display dat of current opponent
            if (game.IsInBattle)
            {
                Console.WriteLine("Current Enemy Information\n--------------------");
                Console.WriteLine($"Species: {game.World.Opponent.Name}\nDescription: {game.World.Opponent.Description}");
                Console.WriteLine($"\tHealth: {game.World.Opponent.Health}/{game.World.Opponent.MaxHealth}");
                Console.WriteLine($"\tWeakness: {game.World.Opponent.Weakness}\n\tResistance: {game.World.Opponent.Resistance}");

                foreach (Skill skill in game.World.Opponent.SkillSet)
                {
                    Console.WriteLine($"Skill: {skill.Name}  |  Element: {skill.Element}\n\tInfo: {skill.Description}");
                }

                if (game.World.Opponent.Charge > 0)
                {
                    Console.WriteLine($"This Creature currently has {game.World.Opponent.Charge} CHARGE.");
                }
                if (game.World.Opponent.Armor > 0)
                {
                    Console.WriteLine($"This Creature currently has {game.World.Opponent.Armor} ARMOR.");
                }
            }
            else
            {
                // Otherwise, just list creatures currently in game
                int index = 0;
                Console.WriteLine("Creature List");
                foreach (Creature creature in game.World.CreatureIndex)
                {
                    index++;
                    Console.WriteLine($"{index}. {creature.Name}\n\t{creature.Description}");
                }
            }
            game.Player.Actions += 1;
        }

        public static void Team(Game game)
        {
            Console.WriteLine($"{game.Player.PlayerName}'s Team Information");
            int index = 0;
            foreach (Creature creature in game.Player.Team)
            {
                index++;
                Console.WriteLine($"--------------------\n{index}. {creature.Name}\nDescription: {creature.Description}");
                Console.WriteLine($"\tHealth: {creature.Health}/{creature.MaxHealth}");
                Console.WriteLine($"\tWeakness: {creature.Weakness}\n\tResistance: {creature.Resistance}");

                foreach (Skill skill in creature.SkillSet)
                {
                    Console.WriteLine($"Skill: {skill.Name}  |  Element: {skill.Element}\n\tInfo: {skill.Description}");
                }

                if (creature.Charge > 0)
                {
                    Console.WriteLine($"This Creature currently has {creature.Charge} CHARGE.");
                }
                if (creature.Armor > 0)
                {
                    Console.WriteLine($"This Creature currently has {creature.Armor} ARMOR.");
                }
            }

            game.Player.Actions += 1;
        }

        // Instant recovery outside of combat
        public static void Rest(Game game)
        {
            if (!game.IsInBattle)
            {
                Console.Write($"{game.Player.PlayerName} took a quick rest. ");
                foreach (Creature creature in game.Player.Team)
                {
                    creature.Health = creature.MaxHealth;
                }
                Console.WriteLine($"{game.Player.PlayerName}'s party was completely healed!");
                game.Player.Actions += 1;
            }
            else
            {
                Console.WriteLine("You can't rest while in battle!");
            }
        }

        public static void Score(Game game)
        {
            Console.WriteLine("Current Player Statistics:\n--------------------");
            Console.WriteLine($"Name: {game.Player.PlayerName}\nWins: {game.Player.Wins} ~|~ Losses: {game.Player.Losses} ~|~ Actions: {game.Player.Actions}");
            game.Player.Actions += 1;
        }

        public static void Quit(Game game)
        {
            // If in battle, forfeit the battle; Otherwise, quit game
            if (game.IsInBattle)
            {
                Console.Write("Forfeit battle? This will count as a loss.");
                string choiceString = "";
                while (choiceString != "YES" && choiceString != "Y" && choiceString != "NO" && choiceString != "N")
                {
                    Console.Write("Please enter Yes/No (Y/N): ");
                    choiceString = Console.ReadLine().Trim().ToUpper();
                }

                if (choiceString == "NO" || choiceString == "N")
                {
                    return;
                }
                else
                {
                    game.Player.Losses += 1;
                    Console.WriteLine($"{game.Player.PlayerName} forfeit the battle.");
                    game.Player.Actions += 1;
                    game.IsInBattle = false;
                }
            }
            else
            {
                Console.WriteLine("Quit Game?");
                string choiceString = "";
                while (choiceString != "YES" && choiceString != "Y" && choiceString != "NO" && choiceString != "N")
                {
                    Console.Write("Please enter Yes/No (Y/N): ");
                    choiceString = Console.ReadLine().Trim().ToUpper();
                }

                if (choiceString == "NO" || choiceString == "N")
                {
                    return;
                }
                else
                {
                    game.Player.Actions += 1;
                    game.IsGameRunning = false;
                }
            }
        }

        public static void Swap(Game game)
        {
            if (game.IsInBattle)
            {
                // If in battle swap active creature
                game.World.ChooseMember(game.Player);
            }
            else
            {
                // Otherwise, swap creatures in party
                game.World.SwapMembers(game.Player);
            }
        }

        public static void Battle(Game game)
        {
            bool canBattle = game.HealthCheck(game);

            // If not in battle, initiate combat
            if (!game.IsInBattle)
            {
                if (canBattle)
                {
                    Console.WriteLine("Enter battle?");
                    string choiceString = "";
                    while (choiceString != "YES" && choiceString != "Y" && choiceString != "NO" && choiceString != "N")
                    {
                        Console.Write("Please enter Yes/No (Y/N): ");
                        choiceString = Console.ReadLine().Trim().ToUpper();
                    }

                    if (choiceString == "NO" || choiceString == "N")
                    {
                        return;
                    }
                    else
                    {
                        game.IsInBattle = true;
                        game.World.SpawnOpponent();
                        Console.WriteLine($"\nEnemy {game.World.Opponent.Name} appeared!\n");
                        game.World.ChooseMember(game.Player);
                    }
                }
                else
                {
                    Console.WriteLine($"{game.Player.PlayerName} has no Creatures that are capable of fighting!");
                }
            }
            else
            {
                // Otherwise choose a skill for your creature to use
                game.PlayerTurn(game);

                if (game.IsInBattle)
                {
                    game.EnemyTurn(game);
                }
            }

            if (game.IsInBattle)
            {
                Console.WriteLine($"{game.Player.PlayerName}'s {game.World.Member.Name}: {game.World.Member.Health}/{game.World.Member.MaxHealth}");
                Console.WriteLine("\t~VS~");
                Console.WriteLine($"Enemy {game.World.Opponent.Name}: {game.World.Opponent.Health}/{game.World.Opponent.MaxHealth}");
            }
        }

        // Checks if player has at least one Monster with health
        public bool HealthCheck(Game game)
        {
            bool isAlive = false;
            foreach (Creature creature in game.Player.Team)
            {
                if (creature.Health > 0)
                {
                    isAlive = true;
                    return isAlive;
                }
            }

            return isAlive;
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

                Console.Write("Enter number for corresponding Skill: ");
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
            Console.WriteLine($"\n{game.Player.PlayerName}'s {game.World.Member.Name} used {playerSkill.Name}!");
            
            UseSkill(playerSkill, game.World.Member, game.World.Opponent);
            game.Player.Actions += 1;

            if (game.World.Opponent.Health <= 0)
            {
                game.World.Opponent.Health = 0;
                Console.WriteLine($"Enemy {game.World.Opponent.Name} was knocked out!");
                Console.WriteLine($"{game.Player.PlayerName}'s {game.World.Member.Name}: {game.World.Member.Health}/{game.World.Member.MaxHealth}");
                Console.WriteLine("\t~VS~");
                Console.WriteLine($"Enemy {game.World.Opponent.Name}: {game.World.Opponent.Health}/{game.World.Opponent.MaxHealth}\n");
                
                game.Player.Wins += 1;
                Console.WriteLine("~ ~ ~You earned a WIN!~ ~ ~");
                game.IsInBattle = false;
            }
        }

        public void EnemyTurn(Game game)
        {
            Random random = new Random();
            int index = random.Next(game.World.Opponent.SkillSet.Count);

            Skill enemySkill = game.World.Opponent.SkillSet[index];
            Console.WriteLine($"Enemy {game.World.Opponent.Name} used {enemySkill.Name}!");
            UseSkill(enemySkill, game.World.Opponent, game.World.Member);

            if (game.World.Member.Health <= 0)
            {
                game.World.Member.Health = 0;
                Console.WriteLine($"{game.Player.PlayerName}'s {game.World.Member.Name} was knocked out!");
                Console.WriteLine($"{game.Player.PlayerName}'s {game.World.Member.Name}: {game.World.Member.Health}/{game.World.Member.MaxHealth}");
                Console.WriteLine("\t~VS~");
                Console.WriteLine($"Enemy {game.World.Opponent.Name}: {game.World.Opponent.Health}/{game.World.Opponent.MaxHealth}\n");
                
                game.Player.Losses += 1;
                Console.WriteLine("- - -You got a LOSS...- - -");
                game.IsInBattle = false;
            }
        }

        public void UseSkill(Skill skill, Creature user, Creature target)
        {
            int damage;

            if (skill.Power > 0)
            {
                if (user.Charge > 0)
                {
                    Console.WriteLine($"The attack's power is boosted due to {user.Name}'s CHARGE!");
                }

                if (target.Armor > 0)
                {
                    Console.WriteLine($"The attack's power is reduced due to {target.Name}'s ARMOR!");
                }

                if (skill.Element == target.Weakness && skill.Element != target.Resistance)
                {
                    damage = skill.Power * 2;
                    if (user.Charge > 0)
                    {
                        damage += user.Charge;
                        user.Charge = 0;
                    }
                    if (target.Armor > 0)
                    {
                        damage -= target.Armor;
                        target.Armor = 0;
                    }
                    target.Health -= damage;

                    Console.WriteLine($"{target.Name} took {damage} damage due to {skill.Element} Weakness!");
                }
                else if (skill.Element == target.Resistance && skill.Element != target.Weakness)
                {
                    damage = skill.Power / 2;
                    if (user.Charge > 0)
                    {
                        damage += user.Charge;
                        user.Charge = 0;
                    }
                    if (target.Armor > 0)
                    {
                        damage -= target.Armor;
                        target.Armor = 0;
                    }
                    target.Health -= damage;
                    Console.WriteLine($"{target.Name} took {damage} damage due to {skill.Element} Resistance!");
                }
                else
                {
                    damage = skill.Power;
                    if (user.Charge > 0)
                    {
                        damage += user.Charge;
                        user.Charge = 0;
                    }
                    if (target.Armor > 0)
                    {
                        damage -= target.Armor;
                        target.Armor = 0;
                    }
                    target.Health -= damage;
                    Console.WriteLine($"{target.Name} took {damage} damage!");
                }
            }

            if (skill.Heal > 0)
            {
                if (user.Health + skill.Heal >= user.MaxHealth)
                {
                    user.Health = user.MaxHealth;
                    Console.WriteLine($"{user.Name} was healed completely!");
                }
                else
                {
                    user.Health += skill.Heal;
                    Console.WriteLine($"{user.Name} regained {skill.Heal} HEALTH!");
                }
            }

            if (skill.Boost > 0)
            {
                user.Charge += skill.Boost;
                Console.WriteLine($"{user.Name} gained {skill.Boost} CHARGE!");
            }

            if (skill.Shield > 0)
            {
                user.Armor += skill.Shield;
                Console.WriteLine($"{user.Name} gained {skill.Shield} ARMOR!");
            }

            Console.WriteLine();
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
