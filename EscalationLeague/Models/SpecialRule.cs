using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscalationLeague.Models
{
    public class SpecialRule
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
    }
}