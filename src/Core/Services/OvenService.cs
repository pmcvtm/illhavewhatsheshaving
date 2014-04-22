using System;
using System.Collections.Generic;

namespace Core.Services
{
	public interface IBakeable
	{
		string Name { get; }
	}

	public abstract class OvenService
	{
		protected List<IBakeable> ThingsInOven;

		public abstract void Bake(int temperature, int minutes);

		public void PutInOven(IBakeable item)
		{
			Console.WriteLine("Put a {0} into the oven", item.Name);
			ThingsInOven.Add(item);
		}

		public void TakeOutOfOven(IBakeable item)
		{
			if (ThingsInOven.Contains(item))
			{
				ThingsInOven.Remove(item);
				Console.WriteLine("Took a {0} out of the oven", item.Name);
			}
			else
			{
				Console.WriteLine("There is no {0} in the oven", item.Name);
			}
		}
	}
}
