using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddedSpriteUrlToCaughModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpriteUrl",
                table: "Pokemans",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpriteUrl",
                table: "CaughtPokemon",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpriteUrl",
                table: "Pokemans");

            migrationBuilder.DropColumn(
                name: "SpriteUrl",
                table: "CaughtPokemon");
        }
    }
}
