using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Realpath.NewWebSite.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "addressid",
                table: "CompanyInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "contactDetailid",
                table: "CompanyInfo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contactDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAddess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pOBoxAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactDetails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "designations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_designations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gallery",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gallery", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serviceid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.id);
                    table.ForeignKey(
                        name: "FK_services_services_Serviceid",
                        column: x => x.Serviceid,
                        principalTable: "services",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    designationid = table.Column<int>(type: "int", nullable: false),
                    addressid = table.Column<int>(type: "int", nullable: false),
                    contactDetailid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.id);
                    table.ForeignKey(
                        name: "FK_members_addresses_addressid",
                        column: x => x.addressid,
                        principalTable: "addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_members_contactDetails_contactDetailid",
                        column: x => x.contactDetailid,
                        principalTable: "contactDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_members_designations_designationid",
                        column: x => x.designationid,
                        principalTable: "designations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfo_addressid",
                table: "CompanyInfo",
                column: "addressid");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfo_contactDetailid",
                table: "CompanyInfo",
                column: "contactDetailid");

            migrationBuilder.CreateIndex(
                name: "IX_members_addressid",
                table: "members",
                column: "addressid");

            migrationBuilder.CreateIndex(
                name: "IX_members_contactDetailid",
                table: "members",
                column: "contactDetailid");

            migrationBuilder.CreateIndex(
                name: "IX_members_designationid",
                table: "members",
                column: "designationid");

            migrationBuilder.CreateIndex(
                name: "IX_services_Serviceid",
                table: "services",
                column: "Serviceid");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfo_addresses_addressid",
                table: "CompanyInfo",
                column: "addressid",
                principalTable: "addresses",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfo_contactDetails_contactDetailid",
                table: "CompanyInfo",
                column: "contactDetailid",
                principalTable: "contactDetails",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfo_addresses_addressid",
                table: "CompanyInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfo_contactDetails_contactDetailid",
                table: "CompanyInfo");

            migrationBuilder.DropTable(
                name: "gallery");

            migrationBuilder.DropTable(
                name: "members");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "contactDetails");

            migrationBuilder.DropTable(
                name: "designations");

            migrationBuilder.DropIndex(
                name: "IX_CompanyInfo_addressid",
                table: "CompanyInfo");

            migrationBuilder.DropIndex(
                name: "IX_CompanyInfo_contactDetailid",
                table: "CompanyInfo");

            migrationBuilder.DropColumn(
                name: "addressid",
                table: "CompanyInfo");

            migrationBuilder.DropColumn(
                name: "contactDetailid",
                table: "CompanyInfo");
        }
    }
}
