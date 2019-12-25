namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doubleToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "HoursOfRent", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "HoursOfRent", c => c.Double(nullable: false));
        }
    }
}
