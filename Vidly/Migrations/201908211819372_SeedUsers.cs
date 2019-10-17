namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0b32da33-bc12-4c06-8288-8439a24821b3', N'admin@vidly.com', 0, N'ADPpj2RhCA2uCM4d1tGqaFptvw3y/Y/wGf0aFZbqhJhEXXGKbegC6abTO7+wYiNu/Q==', N'372f3cda-aab8-4698-81d9-8afd8ce4c591', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8adf8161-f132-49fb-bfff-b10c763d500f', N'jemy@domain.com', 0, N'AAirbyjt57za5zdp0NgyiPZM73fFi0PLUTP2EJ8MmqJhr4e/oX14ZynSAdX0eMeZew==', N'299af74a-1401-4529-aae0-eaaf6e26e597', NULL, 0, 0, NULL, 1, 0, N'jemy@domain.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a01a7449-92d1-4e82-85cb-5d63dcc07172', N'guest@vidly.com', 0, N'AB5xD4T9LzzKQh1NHen4B/z7UMuNbCVuLIwVmmloLaKBh21L4Vliygg/3eF+U2GJjQ==', N'bc9bbe4b-fc13-4bd5-b79d-5d5332ef200a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4b47f3db-3ffa-41bc-a016-1d79f1509b23', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0b32da33-bc12-4c06-8288-8439a24821b3', N'4b47f3db-3ffa-41bc-a016-1d79f1509b23')

");
        }
        
        public override void Down()
        {
        }
    }
}
