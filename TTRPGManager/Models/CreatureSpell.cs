using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public class CreatureSpell
    {
        public int Id { get; set; }
        public int BaseCreatureId { get; set; }
        public int Level { get; set; } // 0 for cantrips, 1-9 for leveled spells

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? DamageDice { get; set; }
        public string CastingTime { get; set; } = string.Empty;
        public string Range { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string? Components { get; set; } = string.Empty;

        public bool IsConcentration { get; set; }
        public bool IsCantrip { get; set; }

        public SpellSchool School { get; set; }
    }
}
