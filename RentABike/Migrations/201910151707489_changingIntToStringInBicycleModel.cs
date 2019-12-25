namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changingIntToStringInBicycleModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bicycles", "FrameSize", c => c.String(nullable: false));
            AlterColumn("dbo.Bicycles", "WheelsSize", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bicycles", "WheelsSize", c => c.Int(nullable: false));
            AlterColumn("dbo.Bicycles", "FrameSize", c => c.Int(nullable: false));
        }
    }
}
