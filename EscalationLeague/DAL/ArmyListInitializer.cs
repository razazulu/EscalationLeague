using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EscalationLeague.Models;

namespace EscalationLeague.DAL
{
    public class ArmyListInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ArmyListDBContext>
    {
        protected override void Seed(ArmyListDBContext context)
        {
            var armyLists = new List<ArmyList>
            {
            new ArmyList{Verified= true,Title= "Splinter Fleet Zulu",DateCreated= DateTime.Parse("2016-04-18")},
            new ArmyList{Verified= true,Title="Rob's Great Company",DateCreated=DateTime.Parse("2016-04-18")},
            new ArmyList{Verified= true,Title="Col.Tasks Minute Men",DateCreated=DateTime.Parse("2016-04-18")},
            new ArmyList{Verified= true,Title="Waaaaaghhh Silence",DateCreated=DateTime.Parse("2016-04-18")},
            new ArmyList{Verified= true,Title="Ash's GK",DateCreated=DateTime.Parse("2016-04-18")},
            new ArmyList{Verified = true,Title="Timmi's DA",DateCreated=DateTime.Parse("2016-04-18")},
            new ArmyList{Verified = true,Title="Ian's Tau",DateCreated=DateTime.Parse("2016-04-18")},
            new ArmyList{Verified = true,Title="Lee's Ravenguard",DateCreated=DateTime.Parse("2016-04-18")}
            };

            armyLists.ForEach(s => context.ArmyLists.Add(s));
            context.SaveChanges();
            /*var detachments = new List<Detatchment>
            {
            new Detatchment{Name="Tyranid CAD",Faction="Tyranids",IsPrimary=true, PointTotal = 500},
            new Detatchment{Name="Guard CAD",Faction="Tempestus Scions", SubFaction = "Astra Millitarum", IsPrimary=true, PointTotal = 500},
            new Detatchment{Name="Ork CAD",Faction="Tyranids",IsPrimary=true, PointTotal = 500},
            new Detatchment{Name="Space Marine CAD",Faction="Tyranids",IsPrimary=true, PointTotal = 500},
            new Detatchment{Name="Space Wolf CAD",Faction="Tyranids",IsPrimary=true, PointTotal = 500},
            };

            detachments.ForEach(s => context.Detachments.Add(s));
            context.SaveChanges();
            var units = new List<Unit>
            {
            new Unit{Name="Termagaunt Brood",UnitType="Infantry", Faction = "Tyranids", WS=3, BS=3, S=3 },
            };
            units.ForEach(s => context.Units.Add(s));
            context.SaveChanges();

            var wargears = new List<Wargear>
            {
                new Wargear {AP = 3, Name = "Missile Launcher", Str = 8}
            };
            wargears.ForEach(s => context.Wargears.Add(s));
            context.SaveChanges();

            var specialRules = new List<SpecialRule>
            {
                new SpecialRule {Description = "This is a very big shooty gun", Name = "BFG1000", Points = 50}
            };
            specialRules.ForEach(s => context.SpecialRules.Add(s));
            context.SaveChanges();*/

        }
    }
}