using System.Collections.Generic;
using Core.Baking;
using Core.Baking.Services;

namespace Core.Tests.Baking
{
	public class StubMixerService : IMixerService
	{
		public bool Mix(List<Ingredient> ingredients)
		{
			return true;
		}
	}
}