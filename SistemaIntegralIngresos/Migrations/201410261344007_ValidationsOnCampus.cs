namespace SistemaIntegralIngresos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidationsOnCampus : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Campus", "Code", c => c.String(nullable: false));
            AlterColumn("dbo.Campus", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Campus", "Name", c => c.String());
            AlterColumn("dbo.Campus", "Code", c => c.String());
        }
    }
}
