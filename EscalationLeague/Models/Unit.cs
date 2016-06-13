using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscalationLeague.Models
{
    public class Unit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UnitType { get; set; }
        public string Faction { get; set; }
        public string SubFaction { get; set; }
        public int WS { get; set; }
        public int BS { get; set; }
        public int S { get; set; }
        public int T { get; set; }
        public int W { get; set; }
        public int I { get; set; }
        public int A { get; set; }
        public int Ld { get; set; }
        public int Sv { get; set; }
        public string UnitComp { get; set; }
        public int DetatchmentID { get; set; }

        public virtual ICollection<Wargear> Wargear { get; set; }
        public virtual ICollection<SpecialRule> SpecialRules { get; set; }
    }
}