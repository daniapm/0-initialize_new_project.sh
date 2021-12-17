using NUnit.Framework;

namespace MyMath.Tests
{
	public class OperationsTests
	{

		[Test]
		public void DebeSerIgual()
		{
			int result = 13;
			var valorEsperado = Operations.Add(5, 8);
			Assert.AreEqual(result, valorEsperado);
		}

		[Test]
		public void NumerosNegativos()
		{
			int result = 3;
			var valorEsperado = Operations.Add(-5, 8);
			Assert.AreEqual(result, valorEsperado);
		}

		[Test]
		public void EsCero()
		{
			int result = 8;
			var valorEsperado = Operations.Add(0, 8);
			Assert.AreEqual(result, valorEsperado);
		}

		[Test]
		public void Ceros()
		{
			int result = 0;
			var valorEsperado = Operations.Add(0, 0);
			Assert.AreEqual(result, valorEsperado);
		}

		[Test]
		public void IsNegative()
		{
			int result = -2;
			var valorEsperado = Operations.Add(-5, 3);
			Assert.AreEqual(result, valorEsperado);
		}

		[Test]
		public void AreNegatives()
		{
			int result = -8;
			var valorEsperado = Operations.Add(-5, -3);
			Assert.AreEqual(result, valorEsperado);
		}
	}
}