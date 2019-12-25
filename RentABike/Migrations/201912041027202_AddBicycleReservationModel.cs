namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBicycleReservationModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BicycleReservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReservationNumber = c.Int(nullable: false),
                        CustomerEmail = c.String(nullable: false),
                        StartRide = c.DateTime(nullable: false),
                        EndRide = c.DateTime(nullable: false),
                        BicycleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bicycles", t => t.BicycleId, cascadeDelete: true)
                .Index(t => t.BicycleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BicycleReservations", "BicycleId", "dbo.Bicycles");
            DropIndex("dbo.BicycleReservations", new[] { "BicycleId" });
            DropTable("dbo.BicycleReservations");
        }
    }
}
