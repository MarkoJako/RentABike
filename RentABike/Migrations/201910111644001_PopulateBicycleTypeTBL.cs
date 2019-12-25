namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBicycleTypeTBL : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BicycleTypes (Name) VALUES ('Road')");
            Sql("INSERT INTO BicycleTypes (Name) VALUES ('MTB')");
            Sql("INSERT INTO BicycleTypes (Name) VALUES ('City')");
            Sql("INSERT INTO BicycleTypes (Name) VALUES ('Treking')");
            Sql("INSERT INTO BicycleTypes (Name) VALUES ('Full Suspenion')");
        }
        
        public override void Down()
        {
        }
    }
}
