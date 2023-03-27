namespace Pokedex.API.ApiModels
	{
	public class PokemonParser
		{
		public int count { get; set; }
		public string next { get; set; }
		public object previous { get; set; }
		public List<Pokemon.Pokemon> results { get; set; }
		}
	}
