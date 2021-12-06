using System;
using System.Collections.Generic;
using System.Text;

namespace Creature.Data
{
    public class Item
    {
        public string ItemName { get; set; }

        public override string ToString() => ItemName;
    }
}
