using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Application.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Autopargid",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Toohind = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Broneering = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autopargid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lepingud",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Too = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Makse = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grandtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lepingud", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tootajad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kasutaja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Roll = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tootajad", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autod");

            migrationBuilder.DropTable(
                name: "Autopargid");

            migrationBuilder.DropTable(
                name: "Lepingud");

            migrationBuilder.DropTable(
                name: "Tootajad");
        }
    }
}
