namespace Pokedex.Db.DbModels
	{
	public class PokemonModel
		{
		public int IdNum { get; set; }
		public string? PokemonName { get; set; }
		public string? PokemonType { get; set; }
		public string? PokemonCategory { get; set; }
		public string? Sprite { get; set; }
		}
	}
