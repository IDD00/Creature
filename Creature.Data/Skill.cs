using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Creature.Data
{
    public class Skill
    {
        public Skill(string name)
        {
            Name = name;
            Element = Elements.Neutral;
            Power = 10;
        }
        [JsonConstructor]
        public Skill(string name, Elements element, int power)
        {
            Name = name;
            Element = element;
            Power = power;
        }

        [JsonProperty(Order = 1)]
        public string Name { get; set; }
        [JsonProperty(Order = 2)]
        public Elements Element { get; set; }
        [JsonProperty(Order = 3)]
        public int Power { get; set; }

        public override string ToString() => Name;
    }
}
