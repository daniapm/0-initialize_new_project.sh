using System;

namespace _5_print_comb
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i <= 99; i++)
			{
				if (i % 10 != i / 10 && i % 10 > i / 10)
				{
					if (i != 89)
						Console.Write("{0:D2}, ", i);
					else
						Console.WriteLine("{0:D2}", i);
				}
			}

		}

	}

}