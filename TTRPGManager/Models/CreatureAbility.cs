using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public class CreatureAbility
    {
        public int Id { get; set; }
        public int BaseCreatureId { get; set; }
        public int? MiscDamageBonus { get; set; }
        public int LegendaryActionCost { get; set; } = 0;

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? DamageDice { get; set; }

        public CreatureAbilityType Type { get; set; }
        public DamageType? DamageType { get; set; }
        public StatType? AbilityStatType { get; set; }
    }
}
