using System;
using System.Collections.Generic;
using System.Text;

namespace Creature.Data
{
    public class Player
    {
        public Player()
        {
            PlayerName = "Player";
            PlayerTeam = new List<Creature>();
            Inventory = new List<Item>();

            Wins = 0;
            Money = 500;
        }

        public string PlayerName { get; set; }

        public List<Creature> PlayerTeam { get; set; }

        public List<Item> Inventory { get; set; }

        public int Money { get; set; }

        public int Wins { get; set; }

        public override string ToString() => PlayerName;
    }
}
