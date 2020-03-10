namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1958a855-329e-4066-965c-8118bb5ac99a', N'guest@vidly.com', 0, N'ACcvbLKQrxEOx7/DtDN3I+P2KPo4rnhe8jrNUEjFtpVNJJVkVa0C4ABHP6XnwuR/Ng==', N'c4354b8a-e32a-4532-8b7a-1a978aa706e5', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'86e0e397-0ff8-442c-beae-ad84afb60995', N'admin@vidly.com', 0, N'AFfmaSa40KWYiUwICWjnoYE2UtN4i2sfHWzAI23XIJLgWlizJjJh2YFi8+fRJE3O6w==', N'0ef1d068-0488-4bd1-8c55-cd971e7416b6', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'16841684-2c0b-48d1-8dc2-66a7d0ca0c9f', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'86e0e397-0ff8-442c-beae-ad84afb60995', N'16841684-2c0b-48d1-8dc2-66a7d0ca0c9f')

");
        }
        
        public override void Down()
        {
        }
    }
}
