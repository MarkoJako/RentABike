namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingPricePerHourFromIntToDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bicycles", "PricePerHour", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bicycles", "PricePerHour", c => c.Int(nullable: false));
        }
    }
}
