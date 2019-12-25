namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePriceInBicycleTBL : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Bicycles SET PricePerHour = 3 WHERE ID = 1003");
            Sql("UPDATE Bicycles SET PricePerHour = 4 WHERE ID = 1005");
            Sql("UPDATE Bicycles SET PricePerHour = 2 WHERE ID= 1006");
            Sql("UPDATE Bicycles SET PricePerHour = 2 WHERE ID = 1007");
            Sql("UPDATE Bicycles SET PricePerHour = 2 WHERE ID = 2010");
            Sql("UPDATE Bicycles SET PricePerHour = 3 WHERE ID = 2012");
        }
        
        public override void Down()
        {
        }
    }
}
