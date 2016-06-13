using EscalationLeague.Models;

namespace EscalationLeague.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EscalationLeague.Models.ArmyListDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EscalationLeague.Models.ArmyListDBContext context)
        {
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //Test army lists data
            context.ArmyLists.AddOrUpdate(a =>a.ID, new ArmyList
            {
                Title = "Splinter Fleet Zulu",
                DateCreated = DateTime.Now,
                MainFaction = "Tyranids",
                SubFaction = "",
                PointTotal = 500,
                Verified = true
            });

            context.ArmyLists.AddOrUpdate(a => a.ID, new ArmyList
            {
                Title = "Ping's Beserkers",
                DateCreated = DateTime.Now,
                MainFaction = "Deamonkin",
                SubFaction = "",
                PointTotal = 500,
                Verified = true
            });

            context.ArmyLists.AddOrUpdate(a => a.ID, new ArmyList
            {
                Title = "Rob's Wolfy Mc.Wolfinsons",
                DateCreated = DateTime.Now,
                MainFaction = "Space Wolves",
                SubFaction = "",
                PointTotal = 500,
                Verified = true
            });

            context.ArmyLists.AddOrUpdate(a => a.ID, new ArmyList
            {
                Title = "Silence's 'ard boyz",
                DateCreated = DateTime.Now,
                MainFaction = "Orks",
                SubFaction = "",
                PointTotal = 500,
                Verified = true
            });

            context.ArmyLists.AddOrUpdate(a => a.ID, new ArmyList
            {
                Title = "Colonel Tasks minute men",
                DateCreated = DateTime.Now,
                MainFaction = "Tempestus Scions",
                SubFaction = "Astra Millitarum",
                PointTotal = 500,
                Verified = true
            });
        }
    }
}
