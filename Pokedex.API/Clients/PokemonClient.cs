﻿using Newtonsoft.Json;
using Pokedex.API.ApiModels;

namespace Pokedex.API.Clients
	{
	public class PokemonDataFetcher
		{
		public static async Task<List<Pokemon>> GetPokemon()
			{
			HttpClient request = new HttpClient();
			var response = await request.GetStringAsync("https://pokeapi.co/api/v2/pokemon?limit=1010");
			PokemonParser poke = JsonConvert.DeserializeObject<PokemonParser>(response);
			return poke.results;
			}

		public static async Task<PokemonData> GetPokemonData(int id)
			{
			HttpClient request = new HttpClient();
			var response = await request.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{id}/");
			PokemonData pokeInfo = JsonConvert.DeserializeObject<PokemonData>(response);
			return pokeInfo;
			}
		}
	}