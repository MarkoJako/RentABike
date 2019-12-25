namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingPropertyNameInMEmbershipType : DbMigration
    {
        public override void Up()
        {
            Sql("update [MembershipTypes] set [DurationInMonths] = [DurationInMounths]");
        }
        
        public override void Down()
        {
            Sql("update [MembershipTypes] set [DurationInMounths] = [DurationInMonths]");
        }
    }
}
