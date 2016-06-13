using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

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
        public string MainFaction { get; set; }
        public string SubFaction { get; set; }
        public decimal PointTotal { get; set; }
        public bool Verified {get; set;}
    }

    public class ArmyListDBContext : DbContext
    {
        public ArmyListDBContext()
        {
            
            Debug.Write(Database.Connection.ConnectionString);
        }

        public DbSet<ArmyList> ArmyLists { get; set; }
    }
}