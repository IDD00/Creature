using System;
using System.Collections.Generic;
using System.Text;

namespace Creature.Data
{
    public class Skill
    {
        public string SkillName { get; set; }

        public bool IsPassiveSkill { get; set; }

        public Elements SkillElement;

        public int SkillPower { get; set; }

        public override string ToString() => SkillName;
    }
}
