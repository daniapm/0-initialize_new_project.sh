using System;
using System.Collections.Generic;

class List
{
	public static int SafePrint(List<int> myList, int n)
	{
		int num = n;
		try
		{

			for (int i = 1; i < num + 1; i++)
			{
				System.Console.WriteLine(i);

			}


		}
		catch
		{
			System.Console.WriteLine("no se pudo");
		}
		return n;

	}

}
