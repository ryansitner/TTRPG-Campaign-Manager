using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public class MovementSpeed
    {
        public int Id { get; set; }
        public int BaseCreatureId { get; set; }
        public int Speed { get; set; }
        public MovementType Type { get; set; } = MovementType.Walking;
        public bool AbleToHover { get; set; } = false;
    }
}
