using System;
using System.Collections.Generic;

namespace Core.Baking.Services
{
	public class ElectricOvenService : OvenService
	{
		public ElectricOvenService()
		{
			ThingsInOven = new List<IBakeable>();
		}

		public override void Bake(int temperature, int minutes)
		{
			//Check for electricity

			//Preheat

			Console.WriteLine("Baking at {0} for {1} minutes", temperature, minutes);

			foreach (var bakeable in ThingsInOven)
			{
				bakeable.HasBeenBaked = true;
			}
		}
	}
}
