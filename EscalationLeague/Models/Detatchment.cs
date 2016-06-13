using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscalationLeague.Models
{
    public class Detatchment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Faction { get; set; }
        public string SubFaction { get; set; }
        public bool IsPrimary { get; set; }
        public decimal PointTotal { get; set; }
        public int ArmylistID { get; set; }
        
        public virtual ICollection<Unit> Units { get; set; }
    }
}