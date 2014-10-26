namespace SistemaIntegralIngresos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnnouncementsAndVisits : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Announcements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Observations = c.String(),
                        InitialDate = c.DateTime(nullable: false),
                        FinalDate = c.DateTime(nullable: false),
                        SpecificDays = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnnouncementId = c.Int(nullable: false),
                        FullName = c.String(nullable: false),
                        TypeEntrance = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Announcements", t => t.AnnouncementId, cascadeDelete: true)
                .Index(t => t.AnnouncementId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Visits", new[] { "AnnouncementId" });
            DropForeignKey("dbo.Visits", "AnnouncementId", "dbo.Announcements");
            DropTable("dbo.Visits");
            DropTable("dbo.Announcements");
        }
    }
}
