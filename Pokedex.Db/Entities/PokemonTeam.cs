namespace Pokedex.Db.DbModels
	{
	public class PokemonTeam
		{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Ability { get; set; }
		public string? Move1 { get; set; }
		public string? Move2 { get; set; }
		public string? Move3 { get; set; }
		public string? Move4 { get; set; }
		public string? HeldItems { get; set; }
		public string? Nature { get; set; }
		public string? Sprite { get; set; }
		public string SpriteUrl { get; set; }

		public int TeamId { get; set; }
		public Team? Team { get; set; }
		}
	}
