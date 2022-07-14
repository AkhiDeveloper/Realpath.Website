using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Realpath.NewWebSite.Migrations
{
    public partial class mig14072022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileUrl",
                table: "services",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileUrl",
                table: "services");
        }
    }
}
