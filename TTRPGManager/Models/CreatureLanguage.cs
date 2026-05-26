using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public class CreatureLanguage
    {
        public int Id { get; set; }
        public int BaseCreatureId { get; set; }
        public LanguageType SelectedLanguage { get; set; }
        public string? CustomLanguage { get; set; }
    }
}
