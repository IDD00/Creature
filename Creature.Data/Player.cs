using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Creature.Data
{
    public class Player
    {
        public Player()
        {
            PlayerName = "Player";
            Team = new List<Creature>();

            Wins = 0;
        }

        [JsonIgnore]
        public string PlayerName { get; set; }
        [JsonIgnore]
        public List<Creature> Team { get; set; }
        [JsonProperty(PropertyName = "Team", Order = 1)]
        public List<string> TeamNames { get; set; } = new List<string>();
        [JsonIgnore]
        public int Wins { get; set; }

        public override string ToString() => PlayerName;
    }
}
