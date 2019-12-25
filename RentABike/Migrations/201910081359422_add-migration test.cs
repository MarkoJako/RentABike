namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationtest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Int(nullable: false));
            DropColumn("dbo.MembershipTypes", "DurationInMounths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DurationInMounths", c => c.Int(nullable: false));
            DropColumn("dbo.MembershipTypes", "DurationInMonths");
        }
    }
}
