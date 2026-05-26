using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public class Town
    {
        public int Id { get; set; }
        public int MapId { get; set; }

        public Map? Map { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? DMNotes { get; set; }

        public List<POI>? PointOfInterest { get; set; } = new List<POI>();

    }
}
