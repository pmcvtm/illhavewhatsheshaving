using System;
using System.Collections.Generic;
using Core.Baking.Services;

namespace Core.Baking
{
	public class CakeMaker
	{
		private readonly OvenService _oven;
		private readonly IMixerService _mixer;

		public CakeMaker(OvenService oven, IMixerService mixer)
		{
			_oven = oven;
			_mixer = mixer;
		}

		public Cake MakeACake(ICakeDto dto)
		{
			Console.WriteLine("Starting work on a {0}", dto.Name);

			_mixer.Mix(dto.Ingredients);

			var cake = new Cake
			{
				Name = dto.Name,
				Ingredients = dto.Ingredients,
				Slices = dto.Ingredients.Count * 3 - 1,
			};
			
			_oven.PutInOven(cake);
			_oven.Bake(350, 30);
			_oven.TakeOutOfOven(cake);

			cake.Decorate();

			Console.WriteLine("The {0} has been made", cake.Name);

			return cake;
		}
	}

	public interface ICakeDto
	{
		string Name { get; }
		List<Ingredient> Ingredients { get; }
	}
}
