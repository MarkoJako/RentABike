namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bicycles", "ImageUrl", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bicycles", "ImageUrl", c => c.String());
        }
    }
}
