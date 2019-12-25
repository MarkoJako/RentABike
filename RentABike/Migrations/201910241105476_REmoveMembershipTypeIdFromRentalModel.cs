namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class REmoveMembershipTypeIdFromRentalModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rentals", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Rentals", new[] { "MembershipTypeId" });
            RenameColumn(table: "dbo.Rentals", name: "MembershipTypeId", newName: "MembershipType_Id");
            AlterColumn("dbo.Rentals", "MembershipType_Id", c => c.Int());
            CreateIndex("dbo.Rentals", "MembershipType_Id");
            AddForeignKey("dbo.Rentals", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Rentals", new[] { "MembershipType_Id" });
            AlterColumn("dbo.Rentals", "MembershipType_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Rentals", name: "MembershipType_Id", newName: "MembershipTypeId");
            CreateIndex("dbo.Rentals", "MembershipTypeId");
            AddForeignKey("dbo.Rentals", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
    }
}
