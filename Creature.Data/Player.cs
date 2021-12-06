using System;
using System.Collections.Generic;
using System.Text;

namespace Creature.Data
{
    public class Player
    {
        public string PlayerName { get; set; }

        public int Wins { get; set; }

        public override string ToString() => PlayerName;
    }
}
