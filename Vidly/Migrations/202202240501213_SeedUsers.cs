namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            //Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'62540daa-9333-46c4-af3c-cf230263e527', N'nikitakhedekar719@gmail.com', 0, N'AKv5LtFnQJxsv+mcgcuVx8pzqlEftpjCR0XXPo25lCETfGxv55W4ZZeFc49NDhaiMw==', N'f4bd58ce-3a0a-409f-8204-56c011820c3c', NULL, 0, 0, NULL, 1, 0, N'nikitakhedekar719@gmail.com')
            //      INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a3e7dd1b-3cf1-437f-b32e-3318e65d3c11', N'admin@nik.com', 0, N'ACOSYcNaQ9RXXC7vAH0el/3dOvQuZ7ynbQnU1IDB6DyzHC3KxiMBx0xLpKOoIu6uYw==', N'3349b4b8-05f2-4456-8752-aff711d6efe2', NULL, 0, 0, NULL, 1, 0, N'admin@nik.com')
                 
            //      INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6be94024-faf6-4fb5-a640-0beafbcc5809', N'CanManageMovie')
           
            //      INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a3e7dd1b-3cf1-437f-b32e-3318e65d3c11', N'6be94024-faf6-4fb5-a640-0beafbcc5809')

            //");
        }
        
        public override void Down()
        {
        }
    }
}
