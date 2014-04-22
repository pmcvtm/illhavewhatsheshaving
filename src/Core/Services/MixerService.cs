using System.Collections.Generic;

namespace Core.Services
{
	public interface IMixerService
	{
		void Mix(List<Ingredient> ingredients);
	}
}
