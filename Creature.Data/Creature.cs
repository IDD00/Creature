using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;

namespace Creature.Data
{
    public class Creature : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Creature(string name)
        {
            Name = name;
            MaxHealth = Health = 100;

            Weakness = Elements.Unknown;
            Resistance = Elements.Unknown;
            Description = "[Insert Creature Description]";

            SkillSet = new List<Skill>();
            Skill basicSkill = new Skill("Attack");
            SkillSet.Add(basicSkill);
        }
        [JsonConstructor]
        public Creature(string name, int health, Elements weak, Elements resist, string description)
        {
            Name = name;
            MaxHealth = Health = health;
            Weakness = weak;
            Resistance = resist;
            Description = description;

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
        public string Description { get; set; }
        [JsonProperty(Order = 6)]
        public List<Skill> SkillSet { get; set; }
        [JsonIgnore]
        public int Charge { get; set; }
        [JsonIgnore]
        public int Armor { get; set; }

        public override string ToString() => Name;
    }
}
