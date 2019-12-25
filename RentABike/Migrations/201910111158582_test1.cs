namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bicycles", "BicycleTypeId", "dbo.BicycleTypes");
            DropIndex("dbo.Bicycles", new[] { "BicycleTypeId" });
            DropColumn("dbo.Bicycles", "BicycleTypeId");
            DropTable("dbo.BicycleTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BicycleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Bicycles", "BicycleTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Bicycles", "BicycleTypeId");
            AddForeignKey("dbo.Bicycles", "BicycleTypeId", "dbo.BicycleTypes", "Id", cascadeDelete: true);
        }
    }
}
