namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewMembershipCard : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Platinum',50, 12, 50)");
        }
        
        public override void Down()
        {
        }
    }
}
