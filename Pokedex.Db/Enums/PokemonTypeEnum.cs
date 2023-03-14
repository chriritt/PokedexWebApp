using System.ComponentModel.DataAnnotations;

namespace Pokedex.Db.Enums
	{
	public enum PokemonTypes
		{
		Normal,
		Fighting,
		Flying,
		Poison,
		Ground,
		Rock,
		Bug,
		Ghost,
		Steel,
		Fire,
		Water,
		Grass,
		Electric,
		Psychic,
		Ice,
		Dragon,
		Dark,
		Fairy,
		[Display(Name = "???")]
		Question
		}
	}
