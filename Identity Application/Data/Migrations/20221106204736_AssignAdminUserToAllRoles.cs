using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identity_Application.Data.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[UserRoles](UserId,RoleId) SELECT 'a8cc0919-7ff3-4520-ba1b-034839f45cf4', Id FROM [security].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId='a8cc0919-7ff3-4520-ba1b-034839f45cf4'");
        }
    }
}
