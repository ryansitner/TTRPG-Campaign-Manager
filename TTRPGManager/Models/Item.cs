using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public class Item
    {
        [Required]
        public int Id { get; set; }
        public int CostInCopper { get; set; } = 0;
        public int? ArmorClassValue { get; set; }
        public int? NormalRange { get; set; }
        public int? MaxRange { get; set; }

        public double Weight { get; set; } = 0;

        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string? DamageDice { get; set; }

        public bool IsMagical { get; set; } = false;
        public bool RequiresAttunement { get; set; } = false;
        public bool IsFinesseWeapon { get; set; } = false;

        public ItemType Type { get; set; }
        public ItemRarity Rarity { get; set; }
        public DamageType? DamageType { get; set; }
        public ArmorType? ArmorType { get; set; }
    }
}
