using Microsoft.AspNetCore.Mvc;
using Pokedex.Db.Entities;
using Pokedex.Db.Repository;
using Pokedex.Models;
using Pokedex.UI.Data;
using System.Diagnostics;

namespace Pokedex.Controllers
	{
	public class HomeController : Controller
		{

		// Inject PokedexContext into the HomeController
		private readonly PokedexContext? _context;

		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger, PokedexContext context)
			{
			_logger = logger;
			_context = context;
			}

		public IActionResult Index()
			{
			return View();
			}

		public async Task<IActionResult> Pokemon()
			{
			// Pulls all Pokemon from the /pokemon endpoint and creates a list with the returned JSON data
			List<Pokemon> list = new List<Pokemon>();
			Task.Run(async () =>
			{
				list = await PokemonClient.GetPokemon();
			}).GetAwaiter().GetResult();
			return View(list);
			}

		[HttpPost]
		public IActionResult AddToCaught(CaughtPokemon caughtPokemon)
			{
			// References the injected PokedexContext class and adds data to the DB using the CaughtPokemon model
			using (var db = new PokedexContext())
				{
				db.CaughtPokemon.Add(caughtPokemon);
				db.SaveChanges();
				}
			return Ok();
			}

		public IActionResult CaughtChecklist()
			{
			// Lists Pokemon in the Caught DB back to the View

			var caught = _context.CaughtPokemon.ToList();
			return View(caught);
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