using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public class Npc : BaseCreature
    {
        // For the "Other" option in your future form
        public string? Location { get; set; }

        // For the "Town" dropdown option
        public int? TownId { get; set; }
        public Town? Town { get; set; }

        // If they are inside a specific POI like a Tavern
        public int? POIId { get; set; }
        public POI? POI { get; set; }
    }
}
