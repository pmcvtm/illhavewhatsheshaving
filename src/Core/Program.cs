using Core.Cake;
using Core.Services;

namespace Core
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var cakeMaker = new CakeMaker(new ElectricOvenService(), new WoodenSpoonService());

			var recipe = new SimpleCakeRecipe();

			cakeMaker.MakeACake(recipe);
		}
	}
}
