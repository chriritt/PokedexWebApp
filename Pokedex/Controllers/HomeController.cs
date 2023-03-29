using Microsoft.AspNetCore.Mvc;
using Pokedex.Db.Repository;
using Pokedex.Models;
using Pokedex.UI.Data;
using System.Diagnostics;

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
			List<Pokemon> list = new List<Pokemon>();
			Task.Run(async () =>
			{
				list = await PokemonClient.GetPokemon();
			}).GetAwaiter().GetResult();
			return View(list);
			}

		public IActionResult NewTeam()
			{
			return View();
			}

		public IActionResult Teams()
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