namespace Pokedex.Db.DbModels
	{
	public class PokemonModel
		{
		public int IdNum { get; set; }
		public string? PokemonName { get; set; }
		public string? Ability { get; set; }
		public string? move1 { get; set; }
		public string? move2 { get; set; }
		public string? move3 { get; set; }
		public string? move4 { get; set; }
		public string? HeldItem { get; set; }
		public string? Nature { get; set; }
		public string? Sprite { get; set; }
		}
	}
