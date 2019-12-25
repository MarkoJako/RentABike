namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewModelRental : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HoursOfRent = c.Double(nullable: false),
                        BikeQuantity = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        MembershipTypeId = c.Int(nullable: false),
                        BicycleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bicycles", t => t.BicycleId, cascadeDelete: true)
                .ForeignKey("dbo.MembershipTypes", t => t.MembershipTypeId, cascadeDelete: true)
                .Index(t => t.MembershipTypeId)
                .Index(t => t.BicycleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "MembershipTypeId", "dbo.MembershipTypes");
            DropForeignKey("dbo.Rentals", "BicycleId", "dbo.Bicycles");
            DropIndex("dbo.Rentals", new[] { "BicycleId" });
            DropIndex("dbo.Rentals", new[] { "MembershipTypeId" });
            DropTable("dbo.Rentals");
        }
    }
}
