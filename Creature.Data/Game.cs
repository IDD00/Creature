using System;
using System.Collections.Generic;
using System.Text;

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
                { "HELP", new Command("HELP", new string[] { "HELP", "H", "COMMANDS" }, Help) },
                { "INVENTORY", new Command("INVENTORY", new string[] { "INVENTORY", "I", "ITEM", "BAG" }, Inventory) },
                { "SHOP", new Command("SHOP", new string[] { "SHOP", "BUY", "MART" }, Shop) },
            };
        }

        public World World { get; private set; }
        public Player Player { get; private set; }
        public Dictionary<string, Command> Commands { get; private set; }

        public bool IsGameRunning { get; set; }
        public bool IsBattling { get; set; }
        public bool IsShopping { get; set; }

        public static void Load()
        {

        }

        public static void Run()
        {

        }

        public static void Help(Game game)
        {

        }

        public static void Inventory(Game game)
        {

        }

        public static void Shop(Game game)
        {

        }
    }
}
