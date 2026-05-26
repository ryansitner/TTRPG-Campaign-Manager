using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public class CreatureTrait
    {
        public int Id { get; set; }
        public int BaseCreatureId { get; set; }
        public string TraitName { get; set; } = null!;
        public string TraitDescription { get; set; } = null!;
    }
}
