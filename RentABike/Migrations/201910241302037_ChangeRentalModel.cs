namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRentalModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rentals", "Bicycle_Id", "dbo.Bicycles");
            DropForeignKey("dbo.Rentals", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Rentals", new[] { "Bicycle_Id" });
            DropIndex("dbo.Rentals", new[] { "MembershipType_Id" });
            RenameColumn(table: "dbo.Rentals", name: "Bicycle_Id", newName: "BicycleId");
            RenameColumn(table: "dbo.Rentals", name: "MembershipType_Id", newName: "MembershipTypeId");
            AlterColumn("dbo.Rentals", "BicycleId", c => c.Int(nullable: false));
            AlterColumn("dbo.Rentals", "MembershipTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Rentals", "MembershipTypeId");
            CreateIndex("dbo.Rentals", "BicycleId");
            AddForeignKey("dbo.Rentals", "BicycleId", "dbo.Bicycles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rentals", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "MembershipTypeId", "dbo.MembershipTypes");
            DropForeignKey("dbo.Rentals", "BicycleId", "dbo.Bicycles");
            DropIndex("dbo.Rentals", new[] { "BicycleId" });
            DropIndex("dbo.Rentals", new[] { "MembershipTypeId" });
            AlterColumn("dbo.Rentals", "MembershipTypeId", c => c.Int());
            AlterColumn("dbo.Rentals", "BicycleId", c => c.Int());
            RenameColumn(table: "dbo.Rentals", name: "MembershipTypeId", newName: "MembershipType_Id");
            RenameColumn(table: "dbo.Rentals", name: "BicycleId", newName: "Bicycle_Id");
            CreateIndex("dbo.Rentals", "MembershipType_Id");
            CreateIndex("dbo.Rentals", "Bicycle_Id");
            AddForeignKey("dbo.Rentals", "MembershipType_Id", "dbo.MembershipTypes", "Id");
            AddForeignKey("dbo.Rentals", "Bicycle_Id", "dbo.Bicycles", "Id");
        }
    }
}
