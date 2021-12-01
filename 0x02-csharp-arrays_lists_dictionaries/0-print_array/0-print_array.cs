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
		var array1 = new int[size];

		if (size == 0)
		{
			Console.WriteLine();
			return array1;
		}

		for (int i = 0; i < size; i++)
		{
			if (i == array1.Length)
			{
				Console.Write(i);
			}
			else
			{
				Console.Write(i + " ");
			}
			array1[i] = i;
		}
		Console.WriteLine();
		return array1;

	}

}
