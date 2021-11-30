using System;

namespace _4_print_hexa
{
	class Program
	{
		static void Main(string[] args)
		{

			int i = 10;
			for (i = 0; i <= 98; i++)
			{
				Console.WriteLine("{0} = 0x{0:x}", i);
			}

		}
	}
}
