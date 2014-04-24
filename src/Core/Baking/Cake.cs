using System.Collections.Generic;
using Core.Baking.Services;

namespace Core.Baking
{
	public class Cake : IBakeable
	{
		public string Name { get; set; }
		public bool HasBeenBaked { get; set; }
		public bool HasBeenDecordated { get; private set; }
		public int Slices { get; set; }
		public List<Ingredient> Ingredients { get; set; }

		public void Decorate()
		{
			if(HasBeenBaked)
				HasBeenDecordated = true;
		}
	}
}
