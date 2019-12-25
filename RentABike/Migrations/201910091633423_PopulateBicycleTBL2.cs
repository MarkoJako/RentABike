namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBicycleTBL2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Bicycles (Name, Type, FrameSize, WheelsSize, NumberInStock) VALUES ('Scott', 'MTB', 19, 29, 5) ");
            Sql("INSERT INTO Bicycles (Name, Type, FrameSize, WheelsSize, NumberInStock) VALUES ('Stevens', 'Cross', 20, 28, 5) ");
            Sql("INSERT INTO Bicycles (Name, Type, FrameSize, WheelsSize, NumberInStock) VALUES ('Giant', 'Road', 22, 28, 5) ");
        }


        public override void Down()
        {
        }
    }
}
