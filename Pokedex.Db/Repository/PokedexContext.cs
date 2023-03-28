using Microsoft.EntityFrameworkCore;
using Pokedex.Db.DbModels;

namespace Pokedex.Db.Repository
	{
	public class PokedexContext : DbContext
		{
		public DbSet<Team> Teams { get; set; }
		public DbSet<PokemonTeam> Pokemans { get; set; }
		public DbSet<CaughtPokemon> CaughtPokemon { get; set; }

		public string DbPath { get; }

		public PokedexContext()
			{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = Path.Join(path, "Pokedex.db");
			}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
				=> options.UseSqlite($"Data Source={DbPath}");
		}
	}