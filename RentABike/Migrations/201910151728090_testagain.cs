namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testagain : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bicycles", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Bicycles", "FrameSize", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Bicycles", "WheelsSize", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Bicycles", "Description", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bicycles", "Description", c => c.String());
            AlterColumn("dbo.Bicycles", "WheelsSize", c => c.String(nullable: false));
            AlterColumn("dbo.Bicycles", "FrameSize", c => c.String(nullable: false));
            AlterColumn("dbo.Bicycles", "Name", c => c.String(nullable: false));
        }
    }
}
