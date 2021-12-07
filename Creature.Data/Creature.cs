using System;
using System.Collections.Generic;
using System.Text;

namespace Creature.Data
{
    public class Creature
    {
        public Creature(string name)
        {
            Name = name;
            MaxHealth = Health = 100;
            Shield = 0;

            Weakness = new List<Elements>();
            Resistance = new List<Elements>();

            SkillSet = new List<Skill>();
            Skill basicSkill = new Skill("Bash");
            SkillSet.Add(basicSkill);
        }

        public Creature(string name, int health, int shield)
        {
            Name = name;
            MaxHealth = Health = health;
            Shield = shield;

            Weakness = new List<Elements>();
            Resistance = new List<Elements>();

            SkillSet = new List<Skill>();
        }

        public string Name { get; set; }

        public int MaxHealth { get; set; }

        public int Health { get; set; }

        public int Shield { get; set; }

        public List<Elements> Weakness { get; set; }

        public List<Elements> Resistance { get; set; }

        public List<Skill> SkillSet { get; set; }

        public override string ToString() => Name;
    }
}
