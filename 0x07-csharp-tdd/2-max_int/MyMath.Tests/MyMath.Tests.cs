using NUnit.Framework;

namespace MyMath.Tests
{
	public class MaxTests
	{

		[Test]
		public void DebeSerIgual()
		{
			List<int> nums = new List<int> { 1, 2, 3, 4, 5, 1, 2 };
			int result = 5;
			var valorEsperado = Operations.Max(nums);
			Assert.AreEqual(result, valorEsperado);
		}
	}
}