namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignRoleToUser : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('053d71c8-c616-4e13-93ee-adf3f47d39c0', '123456')");
        }
        
        public override void Down()
        {
        }
    }
}
