using System.Collections.Generic;
using Core.Baking;

namespace Core.Tests.Baking
{
	public class TestCakeRecipe : ICakeDto
	{
		public string Name { get { return "Test Cake"; } }
		public List<Ingredient> Ingredients { get {return new List<Ingredient>();} }
	}
}