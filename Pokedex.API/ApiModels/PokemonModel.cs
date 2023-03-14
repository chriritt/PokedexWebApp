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

            /*public static List<Pokemon> GetPokemon(int offset)
				{
				var PokeCallTask = PokemonClient.PokeApiCall(offset);
				var result = PokeCallTask.Result;

				JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
				List<Pokemon> pokemonList = JsonConvert.DeserializeObject<List<Pokemon>>(jsonResponse["results"].ToString());
				return pokemonList;*/
            }
        }
    }

