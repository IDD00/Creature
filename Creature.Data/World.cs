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
        
        [JsonIgnore]
        public Creature Opponent { get; set; }
        [JsonIgnore]
        public Creature Member { get; set; }

        public void SpawnOpponent()
        {
            Random random = new Random();
            int index = random.Next(CreatureIndex.Count);

            Creature enemyCreature = new Creature(CreatureIndex[index].Name, CreatureIndex[index].MaxHealth, CreatureIndex[index].Weakness, CreatureIndex[index].Resistance, CreatureIndex[index].Description);
            enemyCreature.SkillSet = CreatureIndex[index].SkillSet;
            Opponent = enemyCreature;
        }

        public void ChooseMember(Player player)
        {
            Console.WriteLine("Choose your Creature!");

            int searchIndex = 0;

            while (searchIndex < 1 || searchIndex > player.Team.Count)
            {
                int index = 0;
                foreach (Creature creature in player.Team)
                {
                    index++;
                    Console.WriteLine($"{index}. {creature.Name}");
                }

                Console.WriteLine("Enter Creature Number: ");
                string searchString = Console.ReadLine();

                bool success = int.TryParse(searchString, out int number);
                if (!success)
                {
                    searchIndex = 0;
                }
                else
                {
                    searchIndex = number;
                }
            }

            Member = player.Team[searchIndex - 1];
            Console.WriteLine($"{player.PlayerName} sent out {Member.Name}!");
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            _creatureNameIndex = CreatureIndex.ToDictionary(creature => creature.Name, creature => creature);
        }

        private Dictionary<string, Creature> _creatureNameIndex;
    }
}
