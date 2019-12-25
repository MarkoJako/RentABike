namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBicycleTBL1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bicycles", "Picture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bicycles", "Picture");
        }
    }
}
