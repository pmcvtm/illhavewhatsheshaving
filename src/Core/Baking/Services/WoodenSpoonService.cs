using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Baking.Services
{
	public class WoodenSpoonService : IMixerService
	{
		public bool Mix(List<Ingredient> ingredients)
		{
			var ingredientList = ingredients.Select(x => 
			                                        string.Format("{0} {1}", x.Measure, x.Name))
			                                .ToArray();

			Console.WriteLine("Mixing {0} with a wooden spoon and some elbow grease."
			                  , string.Join(", ", ingredientList)
				);

			return ingredients.Count < 10;
		}
	}
}