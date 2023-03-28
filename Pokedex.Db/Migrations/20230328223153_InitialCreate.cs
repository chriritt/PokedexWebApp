using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Db.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaughtPokemon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaughtPokemon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Ability = table.Column<string>(type: "TEXT", nullable: true),
                    Move1 = table.Column<string>(type: "TEXT", nullable: true),
                    Move2 = table.Column<string>(type: "TEXT", nullable: true),
                    Move3 = table.Column<string>(type: "TEXT", nullable: true),
                    Move4 = table.Column<string>(type: "TEXT", nullable: true),
                    HeldItems = table.Column<string>(type: "TEXT", nullable: true),
                    Nature = table.Column<string>(type: "TEXT", nullable: true),
                    Sprite = table.Column<string>(type: "TEXT", nullable: true),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemans_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemans_TeamId",
                table: "Pokemans",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaughtPokemon");

            migrationBuilder.DropTable(
                name: "Pokemans");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
