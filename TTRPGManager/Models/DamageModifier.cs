using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public class DamageModifier
    {
        public int Id { get; set; }
        public int BaseCreatureId { get; set; }
        public DamageType Type { get; set; }
        public ModifierType Modifier { get; set; }
    }
}

