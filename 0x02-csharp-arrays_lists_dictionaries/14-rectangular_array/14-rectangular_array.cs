using System;
class Program
{
	static void Main(string[] args)
	{
		int[][] notas;
		notas = new int[5][];
		notas[0] = new int[5];
		notas[1] = new int[5];
		notas[2] = new int[5];
		notas[3] = new int[5];
		notas[4] = new int[5];

		for (int i = 0; i < notas.Length; i++)
		{
			for (int j = 0; j < notas[i].Length; j++)
			{
				if (notas[i][j] == notas[2][2])
					notas[2][2] = 1;
				else
					notas[i][j] = 0;
			}
		}
		for (int i = 0; i < notas.Length; i++)
		{
			for (int j = 0; j < notas[i].Length; j++)
			{
				Console.Write("{0} ", notas[i][j]);
			}
			Console.WriteLine();
		}

	}
}