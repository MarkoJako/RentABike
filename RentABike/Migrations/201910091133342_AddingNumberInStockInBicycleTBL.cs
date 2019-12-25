namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNumberInStockInBicycleTBL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bicycles", "NumberInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bicycles", "NumberInStock");
        }
    }
}
