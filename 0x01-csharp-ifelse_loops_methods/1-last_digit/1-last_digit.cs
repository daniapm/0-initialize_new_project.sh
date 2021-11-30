using System;

class Program
{
	static void Main(string[] args)
	{
		Random rndm = new Random();
		int number = rndm.Next(-10000, 10000);
		int last = Math.Abs(number % 10);
		if (last > 5)
		{
			Console.Write($"The last digit of {number} is {last} and is greater than 5");
		}
		else if (last == 0)
		{
			Console.Write($"The last digit of {number} is {last} and is 0");
		}
		else if (last != 0 && last < 6)
		{
			Console.Write($"The last digit of {number} is {last} and is less than 6 and not 0");
		}
	}
}