using Core.Baking.Services;

namespace Core.Tests.Baking
{
	public class FakeOvenService : OvenService
	{
		public override void Bake(int temperature, int minutes)
		{
			ThingsInOven.ForEach(x => x.HasBeenBaked = true);
		}
	}
}