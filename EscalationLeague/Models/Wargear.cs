using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscalationLeague.Models
{
    public class Wargear
    {
        public int ID { get; set; }
        public int Range { get; set; }
        public int Str { get; set; }
        public int AP { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public int UnitID { get; set; }

        public virtual ICollection<SpecialRule> SpecialRules { get; set; }
    }
}