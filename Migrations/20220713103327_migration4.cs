using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Realpath.NewWebSite.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isBOD",
                table: "members",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isBOD",
                table: "members");
        }
    }
}
