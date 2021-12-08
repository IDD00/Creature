using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Creature.Data
{
    public class Player : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Player()
        {
            PlayerName = "Player";
            Team = new List<Creature>();

            Wins = 0;
            Losses = 0;
            Actions = 0;
        }

        [JsonIgnore]
        public string PlayerName { get; set; }
        [JsonIgnore]
        public List<Creature> Team { get; set; }
        [JsonProperty(PropertyName = "Team", Order = 1)]
        public List<string> TeamNames { get; set; } = new List<string>();
        [JsonIgnore]
        public int Wins { get; set; }
        [JsonIgnore]
        public int Losses { get; set; }
        [JsonIgnore]
        public int Actions { get; set; }

        public override string ToString() => PlayerName;
    }
}
