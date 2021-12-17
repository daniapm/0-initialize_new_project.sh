using NUnit.Framework;

namespace MyMath.Tests
{
	public class MatrixTest
	{

		[Test]
		public void DebeSerIgual()
		{
			int[,] arr = new int[,] { { 2, 2 }, { 4, 4 } };
			int num = 2;
			var valorEsperado = Matrix.Divide(arr, num);
			Assert.AreEqual(new int[,] { { 1, 1 }, { 2, 2 } }, valorEsperado);
		}

		[Test]
		public void NumIsCero()
		{
			int[,] arr = new int[,] { { 2, 2 }, { 4, 4 } };
			int num = 0;
			var valorEsperado = Matrix.Divide(arr, num);
			Assert.AreEqual(null, valorEsperado);
		}

		[Test]
		public void MatrixIsNull()
		{
			int[,] arr = null;
			int num = 3;
			var valorEsperado = Matrix.Divide(arr, num);
			Assert.AreEqual(null, valorEsperado);
		}

		[Test]
		public void IsNegative()
		{
			int[,] arr = new int[,] { { -2, 2 }, { -4, 4 } };
			int num = 2;
			var valorEsperado = Matrix.Divide(arr, num);
			Assert.AreEqual(new int[,] { { -1, 1 }, { -2, 2 } }, valorEsperado);
		}

		[Test]
		public void IsCero()
		{
			int[,] arr = new int[,] { { 0, 2 }, { 0, 4 } };
			int num = 2;
			var valorEsperado = Matrix.Divide(arr, num);
			Assert.AreEqual(new int[,] { { 0, 1 }, { 0, 2 } }, valorEsperado);
		}
	}
}