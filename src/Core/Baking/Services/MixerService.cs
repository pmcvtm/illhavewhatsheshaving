using System.Collections.Generic;

namespace Core.Baking.Services
{
	public interface IMixerService
	{
		bool Mix(List<Ingredient> ingredients);
	}
}
