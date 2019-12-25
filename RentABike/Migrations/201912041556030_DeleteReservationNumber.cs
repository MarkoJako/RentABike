namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteReservationNumber : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE BicycleReservations DROP COLUMN ReservationNumber");
        }
        
        public override void Down()
        {
           
        }
    }
}
