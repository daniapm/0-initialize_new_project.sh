﻿using System;

namespace _5_print_comb
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int numbers = 0; numbers <= 99; numbers++)
			{
				if (numbers != 99)
					Console.Write("{0:D2}, ", numbers);
				else
					Console.WriteLine("{0:D2}", numbers);
			}

		}
	}
}