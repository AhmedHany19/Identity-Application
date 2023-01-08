using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identity_Application.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'a8cc0919-7ff3-4520-ba1b-034839f45cf4', N'Admin', N'ADMIN', N'Admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAEAACcQAAAAEJZHUdVhVHRw7cGWTfZHOQl1EkpSwQUNbbMjjzhujsNvAJwrGjKnhVGlgXGIaGQUYw==', N'UMG7GP2ZOBLKUEQKK56OKP42DMOJ3MFE', N'08ce543f-acc4-4c2b-bb84-da3077f7ab61', NULL, 0, NULL, 1, 0, N'Ahmed', N'wilzy',NULL)\r\n");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id ='a8cc0919-7ff3-4520-ba1b-034839f45cf4'");
        }
    }
}
