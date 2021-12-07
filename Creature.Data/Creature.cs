using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Creature.Data
{
    public class Creature
    {
        public Creature(string name)
        {
            Name = name;
            MaxHealth = Health = 100;

            Weakness = Elements.Unknown;
            Resistance = Elements.Unknown;

            SkillSet = new List<Skill>();
            Skill basicSkill = new Skill("Bash");
            SkillSet.Add(basicSkill);
        }
        [JsonConstructor]
        public Creature(string name, int health, Elements weak, Elements resist)
        {
            Name = name;
            MaxHealth = Health = health;

            Weakness = weak;
            Resistance = resist;

            SkillSet = new List<Skill>();
        }

        [JsonProperty(Order = 1)]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "Health", Order = 2)]
        public int MaxHealth { get; set; }
        [JsonIgnore]
        public int Health { get; set; }
        [JsonProperty(Order = 3)]
        public Elements Weakness { get; set; }
        [JsonProperty(Order = 4)]
        public Elements Resistance { get; set; }
        [JsonProperty(Order = 5)]
        public List<Skill> SkillSet { get; set; }

        public override string ToString() => Name;
    }
}
