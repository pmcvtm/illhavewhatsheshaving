using System;
using System.Collections.Generic;
using Core.Services;

namespace Core.Cake
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

		public void MakeACake(ICakeDto dto)
		{
			Console.WriteLine("Starting work on a {0}", dto.Name);

			_mixer.Mix(dto.Ingredients);
			
			_oven.PutInOven(dto);
			_oven.Bake(350, 30);
			_oven.TakeOutOfOven(dto);

			Console.WriteLine("The {0} has been made", dto.Name);
		}
	}

	public interface ICakeDto : IBakeable
	{
		List<Ingredient> Ingredients { get; }
	}
}
