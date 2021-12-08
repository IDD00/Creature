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

            int searchIndex = -1;

            while (searchIndex < 1 || searchIndex > player.Team.Count)
            {
                int index = 0;
                foreach (Creature creature in player.Team)
                {
                    index++;
                    Console.WriteLine($"{index}. {creature.Name}\n\t{creature.Health}/{creature.MaxHealth}");
                }

                Console.Write("Enter number for corresponding Creature: ");
                string searchString = Console.ReadLine();

                bool success = int.TryParse(searchString, out int number);
                if (!success)
                {
                    searchIndex = -1;
                }
                else if (player.Team[number - 1].Health == 0)
                {
                    Console.WriteLine($"{player.Team[number - 1].Name} is in no shape to battle!");
                    searchIndex = -1;
                }
                else
                {
                    searchIndex = number;
                }
            }

            Member = player.Team[searchIndex - 1];
            player.Actions += 1;
            Console.WriteLine($"\n{player.PlayerName} sent out {Member.Name}!");
        }

        public void SwapMembers(Player player)
        {
            List<Creature> creatures = new List<Creature>();
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                int _index = random.Next(CreatureIndex.Count);
                creatures.Add(CreatureIndex[_index]);
            }

            int choiceIndex = -1;
            while (choiceIndex < 0 || choiceIndex > creatures.Count)
            {
                int index = 0;
                Console.WriteLine("Available Creatures:");
                foreach (Creature creature in creatures)
                {
                    index++;
                    Console.WriteLine($"{index}. {creature.Name}\n\t{creature.Health}/{creature.MaxHealth}");
                }

                Console.Write("Enter number for corresponding Creature or 0 to quit: ");
                string searchString = Console.ReadLine();

                bool success = int.TryParse(searchString, out int number);
                if (!success)
                {
                    choiceIndex = -1;
                }
                else if (number == 0)
                {
                    return;
                }
                else
                {
                    choiceIndex = number;
                }
            }
            choiceIndex -= 1;

            int searchIndex = -1;
            while (searchIndex < 0 || searchIndex > player.Team.Count)
            {
                Console.WriteLine("\nChoose party member to exchange.");
                int index = 0;
                foreach (Creature creature in player.Team)
                {
                    index++;
                    Console.WriteLine($"{index}. {creature.Name}\n\t{creature.Health}/{creature.MaxHealth}");
                }

                Console.Write("Enter number for corresponding Creature or 0 to quit: ");
                string searchString = Console.ReadLine();

                bool success = int.TryParse(searchString, out int number);
                if (!success)
                {
                    searchIndex = -1;
                }
                else if (number == 0)
                {
                    return;
                }
                else
                {
                    searchIndex = number;
                }
            }
            searchIndex -= 1;

            Console.WriteLine($"\nExchange {player.Team[searchIndex].Name} for new {creatures[choiceIndex].Name}?");
            string choiceString = "";
            while (choiceString != "YES" && choiceString != "Y" && choiceString != "NO" && choiceString != "N")
            {
                Console.Write("Please enter Yes/No (Y/N): ");
                choiceString = Console.ReadLine().Trim().ToUpper();
            }

            if (choiceString == "NO" || choiceString == "N")
            {
                return;
            }
            else
            {
                Console.WriteLine($"{player.PlayerName} traded their {player.Team[searchIndex].Name} for a(n) {creatures[choiceIndex].Name}!");
                player.Team.Remove(player.Team[searchIndex]);
                Creature newCreature = new Creature(creatures[choiceIndex].Name, creatures[choiceIndex].MaxHealth, creatures[choiceIndex].Weakness, creatures[choiceIndex].Resistance, creatures[choiceIndex].Description);
                newCreature.SkillSet = creatures[choiceIndex].SkillSet;
                player.Team.Add(newCreature);
                player.Actions += 1;
            }
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            _creatureNameIndex = CreatureIndex.ToDictionary(creature => creature.Name, creature => creature);
        }

        private Dictionary<string, Creature> _creatureNameIndex;
    }
}
