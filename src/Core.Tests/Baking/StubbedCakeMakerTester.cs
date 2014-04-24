using Core.Baking;
using Core.Baking.Services;
using NUnit.Framework;
using Rhino.Mocks;
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

		[Test]
		public void Should_bake_at_350_for_30_minutes()
		{
			var recipe = new TestCakeRecipe();

			var oven = MockRepository.GenerateMock<OvenService>();
			
			var mixer = MockRepository.GenerateStub<IMixerService>();
			mixer.Stub(x => x.Mix(null)).IgnoreArguments().Return(true);

			new CakeMaker(oven, mixer).MakeACake(recipe);

			var args = oven.GetArgumentsForCallsMadeOn(x => x.Bake(0, 0), opt => opt.IgnoreArguments());
			
			args[0][0].ShouldEqual(350);
			args[0][1].ShouldEqual(30);
		}
    }
}
