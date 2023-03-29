using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
using Pokedex.UI.Data;
using System.Diagnostics;

namespace Pokedex.Controllers
	{
	public class HomeController : Controller
		{

		/*private readonly PokedexContext? _context;*/

		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
			{
			_logger = logger;
			}

		public IActionResult Index()
			{
			return View();
			}

		public IActionResult CaughtChecklist()
			{
			return View();
			}


		public IActionResult Pokemon()
			{
			return View();
			}

		public IActionResult Teams()
			{

			return View();
			}

		// Handles Api calls for the New Team Page
		public async Task<IActionResult> NewTeam()
			{
			List<Pokemon> list = new List<Pokemon>();
			Task.Run(async () =>
			{
				list = await PokemonClient.GetPokemon();
			}).GetAwaiter().GetResult();
			return View(list);
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