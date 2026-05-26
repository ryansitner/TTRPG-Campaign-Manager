using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public class Map
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        [Required]
        public string Image { get; set; } = string.Empty;
        public string? GridScale { get; set; }

        public MapType Type { get; set; }

        public bool IsPlayerSafe { get; set; } = false;
    }
}
