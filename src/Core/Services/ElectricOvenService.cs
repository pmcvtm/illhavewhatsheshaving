using System;
using System.Collections.Generic;

namespace Core.Services
{
	public class ElectricOvenService : OvenService
	{
		public ElectricOvenService()
		{
			ThingsInOven = new List<IBakeable>();
		}

		public override void Bake(int temperature, int minutes)
		{
			Console.WriteLine("Baking at {0} for {1} minutes", temperature, minutes);
		}
	}
}
