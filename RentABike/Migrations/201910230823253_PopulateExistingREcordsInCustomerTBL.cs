namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateExistingREcordsInCustomerTBL : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET PhoneNumber = '0601234567' WHERE ID = 1018");
        }
        
        public override void Down()
        {
        }
    }
}
