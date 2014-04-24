using System.Collections.Generic;

namespace Core.Baking
{
	public class SimpleCakeRecipe : ICakeDto
	{
		public SimpleCakeRecipe()
		{
			Name = "simple cake";
			
			Ingredients = new List<Ingredient>
				{
					new Ingredient{Name = "flour", Measure = "1 1/2 c"},
					new Ingredient{Name = "sugar", Measure = "1 c"},
					new Ingredient{Name = "eggs", Measure = "2"},
					new Ingredient{Name = "baking powder", Measure = "1 3/4 tbs"},
					new Ingredient{Name = "milk", Measure = "1/2 c"},
					new Ingredient{Name = "butter", Measure = "1/2 c"},
					new Ingredient{Name = "vanilla", Measure = "2 tsp"},
				};
		}

		public string Name { get; private set; }

		public List<Ingredient> Ingredients { get; private set; }
	}
}
