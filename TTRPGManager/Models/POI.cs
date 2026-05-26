using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public class POI
    {
        public int Id { get; set; }

        public int TownId { get; set; }
        public Town? Town { get; set; }

        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string POIType { get; set; } = string.Empty;
        public string? DMNotes { get; set; }

        // Future-proofing for Stores
        public bool IsStore { get; set; } = false;

        // Navigation Property: NPCs currently residing at this specific POI
        public List<Npc>? Npcs { get; set; } = new List<Npc>();
    }
}
