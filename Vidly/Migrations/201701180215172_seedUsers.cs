namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'324242fb-a369-42c3-b216-0bc15d9edf7c', N'admin@vidly.com', 0, N'ADQSiYmYsIKCI8GAUtf0+FF3b+jaaagy0HDhHKf8dFMWpSEoklo4elPErXXm2JGEQA==', N'36dca15f-0314-41fa-8280-0f5cea995f5e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e5a48688-3ba4-41a5-9be5-bdee8d2a2f61', N'guest@vidly.com', 0, N'AE5VR1cd8u4zNUcP8HluRNXBMRcgUBujCjFWlJz9pDUws6fwY9qcTMwwzdPDi+nLEA==', N'4a7e6c7e-eb09-4ec0-826a-38942c35148c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'da5c47f4-dde4-46ac-82b9-4cd61fdc8c13', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'324242fb-a369-42c3-b216-0bc15d9edf7c', N'da5c47f4-dde4-46ac-82b9-4cd61fdc8c13')

");
        }
        
        public override void Down()
        {
        }
    }
}
