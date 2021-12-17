using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
	public class MaxTests
	{

		[Test]
		public void DebeSerIgual()
		{
			List<int> nums = new List<int> { 1, 2, 3, 4, 5, 1, 2 };
			var valorEsperado = Operations.Max(nums);
			Assert.AreEqual(5, valorEsperado);
		}

		[Test]
		public void ListNull()
		{
			List<int> nums = null;

			int valorEsperado = Operations.Max(nums);
			Assert.AreEqual(0, valorEsperado);
		}

		[Test]
		public void ListEmpy()
		{
			List<int> nums = new List<int>();

			int valorEsperado = Operations.Max(nums);
			Assert.AreEqual(0, valorEsperado);
		}
	}
}