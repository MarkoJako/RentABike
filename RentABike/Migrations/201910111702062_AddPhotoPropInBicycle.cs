namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhotoPropInBicycle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bicycles", "BicycleTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Bicycles", "BicycleTypeId");
            AddForeignKey("dbo.Bicycles", "BicycleTypeId", "dbo.BicycleTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bicycles", "BicycleTypeId", "dbo.BicycleTypes");
            DropIndex("dbo.Bicycles", new[] { "BicycleTypeId" });
            DropColumn("dbo.Bicycles", "BicycleTypeId");
        }
    }
}
