namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembershipTypeTBL : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET SignUpFee = 10 WHERE Id = 2 ");
            Sql("UPDATE MembershipTypes SET SignUpFee = 20 WHERE Id = 3 ");
            Sql("UPDATE MembershipTypes SET SignUpFee = 50 WHERE Id = 4 ");
        }
        
        public override void Down()
        {
        }
    }
}
