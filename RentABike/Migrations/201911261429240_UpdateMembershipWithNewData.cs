namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipWithNewData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MEmbershipTypes SET Name = 'Bronze', SignUpFee = 20, DiscountRate = 20, DurationInMonths = 3 WHERE Id = 2");
            Sql("UPDATE MEmbershipTypes SET Name = 'Silver', SignUpFee = 30, DiscountRate = 30, DurationInMonths = 6 WHERE Id = 3");
            Sql("UPDATE MEmbershipTypes SET Name = 'Gold', SignUpFee = 40, DiscountRate = 40, DurationInMonths = 9 WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
