using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
using System.Diagnostics;

namespace Pokedex.Controllers
	{
	public class HomeController : Controller
		{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
			{
			_logger = logger;
			}

		public IActionResult Index()
			{
			return View();
			}

		public IActionResult Pokemon()
			{
			return View();
			}

		public IActionResult CaughtChecklist()
			{
			return View();
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