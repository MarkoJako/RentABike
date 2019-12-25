namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExistingREcordInCustomerTable : DbMigration
    {
        public override void Up()
        {
             Sql("UPDATE Customers SET DocumentNumber = '12345678' WHERE Id = 1017");
        }
        
        public override void Down()
        {
        }
    }
}
