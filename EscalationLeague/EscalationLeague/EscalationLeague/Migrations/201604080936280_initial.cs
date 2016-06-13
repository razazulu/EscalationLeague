namespace EscalationLeague.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArmyLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        MainFaction = c.String(),
                        SubFaction = c.String(),
                        PointTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Verified = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ArmyLists");
        }
    }
}
