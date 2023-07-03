using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlimeTAP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioNome = table.Column<string>(type: "TEXT", nullable: false),
                    Senha = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Moeda = table.Column<float>(type: "REAL", nullable: true),
                    MoedaTotal = table.Column<float>(type: "REAL", nullable: true),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Xp = table.Column<int>(type: "INTEGER", nullable: false),
                    Nivel = table.Column<int>(type: "INTEGER", nullable: false),
                    Diamante = table.Column<int>(type: "INTEGER", nullable: true),
                    Gema = table.Column<int>(type: "INTEGER", nullable: true),
                    Multiplicador = table.Column<float>(type: "REAL", nullable: true),
                    Upgrade1 = table.Column<int>(type: "INTEGER", nullable: true),
                    Upgrade2 = table.Column<int>(type: "INTEGER", nullable: true),
                    Upgrade3 = table.Column<int>(type: "INTEGER", nullable: true),
                    Upgrade4 = table.Column<int>(type: "INTEGER", nullable: true),
                    Upgrade5 = table.Column<int>(type: "INTEGER", nullable: true),
                    Upgrade6 = table.Column<int>(type: "INTEGER", nullable: true),
                    Upgrade7 = table.Column<int>(type: "INTEGER", nullable: true),
                    Upgrade8 = table.Column<int>(type: "INTEGER", nullable: true),
                    Upgrade9 = table.Column<int>(type: "INTEGER", nullable: true),
                    Upgrade10 = table.Column<int>(type: "INTEGER", nullable: true),
                    Upgrade11 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
