using System;
using System.IO;
using Newtonsoft.Json;
using Creature.Data;

namespace Creature
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Test.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            Game game = Game.Load();
            game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFilename));

            Console.Write("Please enter a name: ");
            string name = Console.ReadLine().Trim();

            if (name != null)
            {
                game.Player.PlayerName = name;
            }

            game.Run();
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}
