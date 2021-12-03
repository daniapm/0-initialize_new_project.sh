using System;
class Array
{
	public static void Reverse(int[] array)
	{
		int i;

		if (array == null || array.Length == 0)
			Console.WriteLine();
		else
		{
			for (i = array.Length - 1; i >= 0; i--)
			{
				if (i == array.Length)
				{
					Console.Write(array[i]);
				}
				else
				{
					Console.Write($"{array[i]} ");
				}
			}
			Console.WriteLine();
		}
	}

}
