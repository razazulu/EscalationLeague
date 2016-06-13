using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EscalationLeague.Models
{
    public class ArmyList
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Date Created")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }
        public bool Verified {get; set;}

        public virtual ICollection<Detatchment> Detachments { get; set; }
    }
}