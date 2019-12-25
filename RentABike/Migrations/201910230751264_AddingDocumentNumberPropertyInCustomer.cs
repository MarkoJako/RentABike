namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDocumentNumberPropertyInCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DocumentNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DocumentNumber");
        }
    }
}
