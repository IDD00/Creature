using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Creature.Data
{
    public class World
    {
        [JsonConstructor]
        public World()
        {
            CreatureIndex = new List<Creature>();
            _creatureNameIndex = new Dictionary<string, Creature>();
        }

        public List<Creature> CreatureIndex { get; set; }

        public Creature Opponent { get; set; }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            _creatureNameIndex = CreatureIndex.ToDictionary(creature => creature.Name, creature => creature);
        }

        private Dictionary<string, Creature> _creatureNameIndex;
    }
}
