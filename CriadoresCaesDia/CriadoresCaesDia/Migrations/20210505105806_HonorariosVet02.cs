using Microsoft.EntityFrameworkCore.Migrations;

namespace CriadoresCaesDia.Migrations
{
    public partial class HonorariosVet02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Honorarios",
                table: "Veterinarios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Honorarios",
                table: "Veterinarios");
        }
    }
}
