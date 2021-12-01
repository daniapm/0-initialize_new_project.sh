using System;

class Array
{
	public static int[] CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;


		}
		int[] array1 = new int[size];

		for (int i = 0; i < size; i++)
		{
			array1[i] = i;
		}

		for (int j = 0; j < size; j++)
		{
			if (size != 0)
			{
				if (j == array1.Length)
				{
					Console.Write(j);
				}
				else
				{
					Console.Write(j + " ");
				}

			}
			else
			{
				Console.WriteLine();
			}

		}
		Console.WriteLine();
		return array1;

	}

}
