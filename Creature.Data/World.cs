using System;
using System.Collections.Generic;
using System.Text;

namespace Creature.Data
{
    public class World
    {
        public World()
        {
            CreatureIndex = new List<Creature>();
            _creatureNameIndex = new Dictionary<string, Creature>();

            ItemIndex = new List<Item>();
            _itemNameIndex = new Dictionary<string, Item>();
        }

        public List<Creature> CreatureIndex { get; set; }

        public List<Item> ItemIndex { get; set; }

        public Creature Opponent { get; set; }

        private Dictionary<string, Creature> _creatureNameIndex;
        private Dictionary<string, Item> _itemNameIndex;
    }
}
