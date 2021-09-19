using Microsoft.EntityFrameworkCore.Migrations;

namespace BiblioFAP.Migrations
{
    public partial class AddingAccessLevelOnUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessLevelId",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessLevelId",
                table: "User");
        }
    }
}
