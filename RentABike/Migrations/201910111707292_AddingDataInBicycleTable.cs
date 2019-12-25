namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDataInBicycleTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Bicycles (Name, FrameSize, WheelsSize, NumberInStock, BicycleTypeId, Description) VALUES('Scott Scale', 19, 29, 5, 2, 'Full Shimano XT group, 1x11, Rock Shox Reba suspension')");
            Sql("INSERT INTO Bicycles (Name, FrameSize, WheelsSize, NumberInStock, BicycleTypeId, Description) VALUES('Giant Defy', 22, 28, 5, 1, 'Ultegra Di2, Carbon, 2x11')");
            Sql("INSERT INTO Bicycles (Name, FrameSize, WheelsSize, NumberInStock, BicycleTypeId, Description) VALUES('Santa Cruz', 18, 29, 3, 5, 'Sram XO, Carbon, 1x11, Fox suspension 150mm')");
            Sql("INSERT INTO Bicycles (Name, FrameSize, WheelsSize, NumberInStock, BicycleTypeId) VALUES('KTM Maranello', 17, 28, 3, 3)");
            Sql("INSERT INTO Bicycles (Name, FrameSize, WheelsSize, NumberInStock, BicycleTypeId) VALUES('KTM Teramo', 20, 28, 3, 3)");
            Sql("INSERT INTO Bicycles (Name, FrameSize, WheelsSize, NumberInStock, BicycleTypeId) VALUES('Stevens Cross X6', 20, 28, 3, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
