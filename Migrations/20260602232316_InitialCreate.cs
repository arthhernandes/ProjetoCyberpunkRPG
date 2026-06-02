using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoCyberpunkRPG.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Atributos_Forca = table.Column<int>(type: "INTEGER", nullable: false),
                    Atributos_Destreza = table.Column<int>(type: "INTEGER", nullable: false),
                    Atributos_Constituicao = table.Column<int>(type: "INTEGER", nullable: false),
                    Atributos_Inteligencia = table.Column<int>(type: "INTEGER", nullable: false),
                    Atributos_Sabedoria = table.Column<int>(type: "INTEGER", nullable: false),
                    Atributos_Carisma = table.Column<int>(type: "INTEGER", nullable: false),
                    PVMaximo = table.Column<int>(type: "INTEGER", nullable: false),
                    ClasseNome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personagens");
        }
    }
}
