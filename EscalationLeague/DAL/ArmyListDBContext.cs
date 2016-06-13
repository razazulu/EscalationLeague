using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using EscalationLeague.Models;

namespace EscalationLeague.DAL
{
    public class ArmyListDBContext : DbContext
    {
        public ArmyListDBContext() : base("ArmyListDBContext")
        {
            Debug.Write(Database.Connection.ConnectionString);
        }

        public DbSet<ArmyList> ArmyLists { get; set; }
        public DbSet<Detatchment> Detachments { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Wargear> Wargears { get; set; }
        public DbSet<SpecialRule> SpecialRules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}