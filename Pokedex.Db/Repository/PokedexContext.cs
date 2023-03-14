using Microsoft.EntityFrameworkCore;
using Pokedex.Db.DbModels;

namespace Pokedex.Db.Repository
	{
	public class PokedexContext : DbContext
		{
		public DbSet<TeamModel> Teams { get; set; }
		public DbSet<PokemonTeamModel> PokemonTeamMember { get; set; }
		public DbSet<CaughtPokemonModel> CaughtPokemon { get; set; }

		public string DbPath { get; } //or this

		public PokedexContext()
			{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = Path.Join(path, "Pokemon.db"); //may not need this
			}

		/*protected override void OnConfiguring(DbContextOptionsBuilder options)
		=> options.UseSqlite($"Data Source=Pokemon.db");*/
		}
	}