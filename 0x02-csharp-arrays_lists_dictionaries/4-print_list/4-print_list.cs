using System;
using System.Collections.Generic;

class List
{
	public static List<int> CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
		}
		List<int> mylist = new List<int>(size);
		for (int i = 0; i < size; i++)
		{
			mylist.Add(i);
			if (i == size)
			{
				Console.Write(i);
			}
			else
			{
				Console.Write($"{i} ");
			}

		}
		Console.WriteLine();
		return mylist;
	}

}
