using Core.Baking;
using NUnit.Framework;
using Should;

namespace Core.Tests.Baking
{
	[TestFixture]
    public class StubbedCakeMakerTester
    {
		[Test]
		public void Should_bake_and_decorate_cake_with_homemade_fakes()
		{
			var recipe = new TestCakeRecipe();

			var cakeMaker = new CakeMaker(new FakeOvenService(), new StubMixerService());

			var cake = cakeMaker.MakeACake(recipe);

			cake.HasBeenBaked.ShouldBeTrue();
			cake.HasBeenDecordated.ShouldBeTrue();
		}
    }
}
