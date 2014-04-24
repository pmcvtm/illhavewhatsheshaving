using Core.Baking;
using Core.Baking.Services;

namespace Core
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var cakeMaker = new Baking.CakeMaker(new ElectricOvenService(), new WoodenSpoonService());

			var recipe = new SimpleCakeRecipe();

			var cake = cakeMaker.MakeACake(recipe);
		}
	}
}
