using System;

namespace _2_print_alphabet
{
	class Program
	{
		static void Main(string[] args)
		{
			char letra = 'a';
			for (letra = 'a'; letra <= 'z'; letra++)
			{
				if (letra != 'q' && letra != 'e')
				{
					Console.Write(letra);
				}
			}

		}

	}
}