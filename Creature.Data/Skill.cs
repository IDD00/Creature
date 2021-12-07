using System;
using System.Collections.Generic;
using System.Text;

namespace Creature.Data
{
    public class Skill
    {
        public Skill(string name)
        {
            SkillName = name;
            Element = Elements.Neutral;
            Power = 10;
            Guard = 0;
            Heal = 0;
        }

        public Skill(string name, Elements element, int power, int guard, int heal)
        {
            SkillName = name;
            Element = element;
            Power = power;
            Guard = guard;
            Heal = heal;
        }

        public string SkillName { get; set; }

        public Elements Element;

        public int Power { get; set; }

        public int Guard { get; set; }

        public int Heal { get; set; }

        public override string ToString() => SkillName;
    }
}
