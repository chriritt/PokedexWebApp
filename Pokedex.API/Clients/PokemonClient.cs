using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static Pokedex.API.ApiModels.PokemonModel;

namespace Pokedex.API.Clients
	{
	[Route("api/[controller]")]
	[ApiController]
	public class PokemonClient
		{
		[HttpGet]
		public async Task<PokeApiResults> PokemonList()
			{
			var pokeClient = new HttpClient();
			var offset = 0;

			var baseUrl = $"https://pokeapi.co/api/v2/pokemon?offset={offset}";

			var apiResponse = await pokeClient.GetAsync(baseUrl);
			apiResponse.EnsureSuccessStatusCode();
			var response = await apiResponse.Content.ReadAsStringAsync();
			var pokeApiResult = JsonConvert.DeserializeObject<PokeApiResults>(response);

			return pokeApiResult;
			}
		}
	}