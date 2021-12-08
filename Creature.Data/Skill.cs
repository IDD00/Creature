using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;

namespace Creature.Data
{
    public class Skill : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Skill(string name)
        {
            Name = name;
            Element = Elements.Neutral;
            Power = 10;
            Description = "[Insert Skill Description]";
        }
        [JsonConstructor]
        public Skill(string name, Elements element, int power, string description)
        {
            Name = name;
            Element = element;
            Power = power;
            Description = description;
        }

        [JsonProperty(Order = 1)]
        public string Name { get; set; }
        [JsonProperty(Order = 2)]
        public Elements Element { get; set; }
        [JsonProperty(Order = 3)]
        public int Power { get; set; }
        [JsonProperty(Order = 4)]
        public string Description { get; set; }
        public int Boost { get; set; }
        public int Shield { get; set; }
        public int Heal { get; set; }

        public override string ToString() => Name;
    }
}
