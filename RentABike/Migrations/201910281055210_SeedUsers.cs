namespace RentABike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'053d71c8-c616-4e13-93ee-adf3f47d39c0', N'user@rentabike.com', 0, N'AGoRsI8ND59GY8Sp1fxkx3SwXHQs1uIEXa0/EkmKmeREeUDUao6h6WLtHP8XCbPx/Q==', N'478e1ad9-f4c0-4e50-9478-fc680834551c', NULL, 0, 0, NULL, 1, 0, N'user@rentabike.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ec07a54a-c147-49ae-83cb-5dbde5620097', N'admin@rentabike.com', 0, N'AKEgx3s+7McT78+7pOPtgLQFLB78+nR+y2/BV5iQSsh7xeFFNQA1XpmGbN1VhR0X+Q==', N'84db9129-6cf0-465a-994f-06d31e0d1264', NULL, 0, 0, NULL, 1, 0, N'admin@rentabike.com')
         
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ab311358-3769-4bfc-b2e8-7f26593d254c', N'Admin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ec07a54a-c147-49ae-83cb-5dbde5620097', N'ab311358-3769-4bfc-b2e8-7f26593d254c')


        ");
        }
        
        public override void Down()
        {
        }
    }
}
