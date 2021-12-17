using NUnit.Framework;

namespace Text
{
	public class Tests
	{
		[Test]
		public void Lowercase()
		{
			string myString = "ana";
			var valorEsperado = Str.IsPalindrome(myString);
			Assert.AreEqual(true, valorEsperado);
		}

		[Test]
		public void Uppercase()
		{
			string myString = "anA";
			var valorEsperado = Str.IsPalindrome(myString);
			Assert.AreEqual(true, valorEsperado);
		}

		[Test]
		public void Spaces()
		{
			string myString = "an A";
			var valorEsperado = Str.IsPalindrome(myString);
			Assert.AreEqual(true, valorEsperado);
		}
		[Test]
		public void StringVoid()
		{
			string myString = " ";
			var valorEsperado = Str.IsPalindrome(myString);
			Assert.AreEqual(true, valorEsperado);
		}

		public void IsFalse()
		{
			string myString = "Roma";
			var valorEsperado = Str.IsPalindrome(myString);
			Assert.AreEqual(false, valorEsperado);
		}
	}
}