using System;

namespace _5_print_comb
{
	class Program
	{
		static void Main(string[] args)
		{
			int firts = 0;
			int last = 0;
			for (firts = 0; firts <= 9; firts++)
			{
				for (last = 0; last <= 9; last++)
				{
					if (last == 9 && firts == 9)
					{
						Console.WriteLine($"{firts}{last}");
					}
					else
					{
						Console.Write($"{firts}{last}, ");
					}

				}

			}
		}
	}
}
