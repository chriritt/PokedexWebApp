using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pokedex.Db.Repository;
using Pokedex.Models;
using System.Diagnostics;
using static Pokedex.API.ApiModels.PokemonModel;

namespace Pokedex.Controllers
	{
	public class HomeController : Controller
		{
		private readonly PokedexContext _pokedexDB = new PokedexContext();
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
			{
			_logger = logger;
			}

		public async Task<IActionResult> Index()
			{
			return View();
			}

		public IActionResult CaughtChecklist()
			{
			return View();
			}

		// Handles Api calls for the Pokemon Page
		public async Task<IActionResult> Pokemon()
			{
			var pokeClient = new HttpClient();

			var baseUrl = $"https://pokeapi.co/api/v2/pokemon-species?limit=10000";

			var apiResponse = await pokeClient.GetAsync(baseUrl);
			apiResponse.EnsureSuccessStatusCode();
			var response = await apiResponse.Content.ReadAsStringAsync();
			var pokeApiResult = JsonConvert.DeserializeObject<PokeApiResults>(response);

			return View(pokeApiResult.Results);
			}


		public IActionResult TeamBuilder()
			{
			return View();
			}

		public IActionResult About()
			{
			return View();
			}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
			{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
			}
		}
	}