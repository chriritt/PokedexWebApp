using Newtonsoft.Json;

namespace Pokedex.API.ApiModels
	{
	public class PokemonModel
		{
		public class Pokemon
			{
			[JsonProperty("name")]
			public string Name { get; set; }

			[JsonProperty("url")]
			public string Url { get; set; }
			}



		public class PokeApiResults
			{
			[JsonProperty("count")]
			public int Count { get; set; }

			[JsonProperty("next")]
			public string Next { get; set; }

			[JsonProperty("previous")]
			public object Previous { get; set; }
			[JsonProperty("results")]
			public List<Pokemon> Results { get; set; }
			}

		public class Sprites
			{
			public string front_default { get; set; }
			}

		public class RootObject
			{
			/*			public Ability[] abilities { get; set; }
						public object[] held_items { get; set; }
						public Move[] moves { get; set; }*/
			/*			public string name { get; set; }*/

			/*			public Stat[] stats { get; set; }*/

			}
		}
	}

