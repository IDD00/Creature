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
                Console.Write("\n> ");
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
            int index = 1;
            foreach (Creature creature in game.World.CreatureIndex)
            {
                Console.WriteLine($"Index #{index}");
                Console.WriteLine($"Species: {creature.Name}\nLife: {creature.Health}/{creature.MaxHealth}");
                Console.WriteLine($"Weakness: {creature.Weakness}\tResistance: {creature.Resistance}\n---Skills---");
                int count = 1;
                foreach (Skill skill in creature.SkillSet)
                {
                    Console.WriteLine($"{count}. Name: {skill.Name}\tElement: {skill.Element}\tPower: {skill.Power}");
                    count++;
                }
                Console.WriteLine();
                index++;
            }
        }

        public static void Quit(Game game)
        {
            game.IsGameRunning = false;
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
                        Player.Team.Add(creature);
                        break;
                    }
                }
            }
        }
    }
}
