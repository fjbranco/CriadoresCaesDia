using Microsoft.EntityFrameworkCore.Migrations;

namespace CriadoresCaesDia.Migrations
{
    public partial class Veterinarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veterinarios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaesVeterinarios",
                columns: table => new
                {
                    ListaCaesTratadosPeloVeterinarioId = table.Column<int>(type: "int", nullable: false),
                    ListadeVeterinariosQueTrataramOCaoId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaesVeterinarios", x => new { x.ListaCaesTratadosPeloVeterinarioId, x.ListadeVeterinariosQueTrataramOCaoId });
                    table.ForeignKey(
                        name: "FK_CaesVeterinarios_Caes_ListaCaesTratadosPeloVeterinarioId",
                        column: x => x.ListaCaesTratadosPeloVeterinarioId,
                        principalTable: "Caes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaesVeterinarios_Veterinarios_ListadeVeterinariosQueTrataramOCaoId",
                        column: x => x.ListadeVeterinariosQueTrataramOCaoId,
                        principalTable: "Veterinarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaesVeterinarios_ListadeVeterinariosQueTrataramOCaoId",
                table: "CaesVeterinarios",
                column: "ListadeVeterinariosQueTrataramOCaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaesVeterinarios");

            migrationBuilder.DropTable(
                name: "Veterinarios");
        }
    }
}
