namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePriceInDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "Price", c => c.Int(nullable: false));
        }
    }
}
