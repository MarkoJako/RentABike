namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteFrameSizeFromBicycleTBL : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Bicycles", "FrameSize");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bicycles", "FrameSize", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
