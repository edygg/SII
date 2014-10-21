namespace SistemaIntegralIngresos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCodeToCampus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Campus", "Code", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Campus", "Code");
        }
    }
}
