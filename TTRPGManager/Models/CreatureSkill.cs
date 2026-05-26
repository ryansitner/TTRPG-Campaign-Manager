using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public class CreatureSkill
    {
        public int Id { get; set; }
        public int? OverrideBonus { get; set; }
        public SkillType Skill { get; set; }
        public ProficiencyLevel Proficiency { get; set; } = ProficiencyLevel.None;
    }
}
