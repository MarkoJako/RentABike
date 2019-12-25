namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBicycleTBL : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Bicycles SET Type = 'MTB' WHERE Id = 1");
            Sql("UPDATE Bicycles SET Type = 'Treking' WHERE Id = 2");
        }

        public override void Down()
        {
        }
    }
}
