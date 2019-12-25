namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class REmovingBicycleIdFromREntal : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rentals", "BicycleId", "dbo.Bicycles");
            DropIndex("dbo.Rentals", new[] { "BicycleId" });
            RenameColumn(table: "dbo.Rentals", name: "BicycleId", newName: "Bicycle_Id");
            AlterColumn("dbo.Rentals", "Bicycle_Id", c => c.Int());
            CreateIndex("dbo.Rentals", "Bicycle_Id");
            AddForeignKey("dbo.Rentals", "Bicycle_Id", "dbo.Bicycles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Bicycle_Id", "dbo.Bicycles");
            DropIndex("dbo.Rentals", new[] { "Bicycle_Id" });
            AlterColumn("dbo.Rentals", "Bicycle_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Rentals", name: "Bicycle_Id", newName: "BicycleId");
            CreateIndex("dbo.Rentals", "BicycleId");
            AddForeignKey("dbo.Rentals", "BicycleId", "dbo.Bicycles", "Id", cascadeDelete: true);
        }
    }
}
