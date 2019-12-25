namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MEmbershipTypes SET SignUpFee = 10, DiscountRate = 20, DurationInMonths = 1 WHERE Id = 2");
            Sql("UPDATE MEmbershipTypes SET SignUpFee = 20, DiscountRate = 30, DurationInMonths = 3 WHERE Id = 3");
            Sql("UPDATE MEmbershipTypes SET SignUpFee = 50, DiscountRate = 50, DurationInMonths = 12 WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
