namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPricePerHourInBicycle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bicycles", "PricePerHour", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bicycles", "PricePerHour");
        }
    }
}
