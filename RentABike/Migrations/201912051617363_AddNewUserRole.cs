namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewUserRole : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('c9408102-2736-4715-85ec-7e01f6049af2', '123456')");
        }

        public override void Down()
        {
        }
    }
}
