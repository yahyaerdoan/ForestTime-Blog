using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForestTime.DataAccessLayer.Migrations
{
    public partial class UserAndRoleIdRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AspNetRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "AspNetRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
