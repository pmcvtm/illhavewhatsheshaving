using System.Collections.Generic;

namespace Core.Baking.Services
{
	public interface IMixerService
	{
		void Mix(List<Ingredient> ingredients);
	}
}
