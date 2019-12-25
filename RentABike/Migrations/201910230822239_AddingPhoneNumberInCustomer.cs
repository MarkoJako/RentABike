namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPhoneNumberInCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "PhoneNumber");
        }
    }
}
