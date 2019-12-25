namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserInRoles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AspNetRoles (Id, Name) VALUES (123456,'User')");
        }
        
        public override void Down()
        {
        }
    }
}
