namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changePictureDataType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bicycles", "ImageUrl", c => c.String());
            DropColumn("dbo.Bicycles", "Picture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bicycles", "Picture", c => c.Binary());
            DropColumn("dbo.Bicycles", "ImageUrl");
        }
    }
}
