using System.Collections.Generic;
using Core.Baking;
using Core.Baking.Services;
using NUnit.Framework;
using Should;

namespace Core.Tests.Baking
{
	[TestFixture]
    public class CakeMakerTester
    {
		[Test]
		public void Should_bake_and_decorate_cake()
		{
			var recipe = new TestCakeRecipe();

			var cakeMaker = new CakeMaker(new ElectricOvenService(), new WoodenSpoonService());

			var cake = cakeMaker.MakeACake(recipe);

			cake.HasBeenBaked.ShouldBeTrue();
			cake.HasBeenDecordated.ShouldBeTrue();
		}
    }

	public class TestCakeRecipe : ICakeDto
	{
		public string Name { get { return "Test Cake"; } }
		public List<Ingredient> Ingredients { get {return new List<Ingredient>();} }
	}
}
