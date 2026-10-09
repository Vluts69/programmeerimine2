using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Application.Migrations
{
    /// <inheritdoc />
    public partial class AddAutoDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mark",
                table: "Autod",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mudel",
                table: "Autod",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Registreerimisnumber",
                table: "Autod",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mark",
                table: "Autod");

            migrationBuilder.DropColumn(
                name: "Mudel",
                table: "Autod");

            migrationBuilder.DropColumn(
                name: "Registreerimisnumber",
                table: "Autod");
        }
    }
}
