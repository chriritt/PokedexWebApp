using Microsoft.AspNetCore.Mvc.RazorPages;
using static Pokedex.API.ApiModels.PokemonModel;

namespace Pokedex.UI.Views.Home
	{
	public class PokemonList : PageModel
		{
		public List<Pokemon>? Pokemans;
		public int offset = 0;

		public void OnGet()
			{

			}
		}
	}
