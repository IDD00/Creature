using System;
using System.Collections.Generic;
using System.Text;

namespace Creature.Data
{
    public class Creature
    {
        public string Name { get; set; }

        public List<Elements> Weakness { get; set; }

        public List<Elements> Resistance { get; set; }

        public List<Skill> SkillSet = new List<Skill>();

        public override string ToString() => Name;
    }
}
