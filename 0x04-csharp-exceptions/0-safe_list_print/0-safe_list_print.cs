using System;
using System.Collections.Generic;

class List
{
	public static int SafePrint(List<int> myList, int n)
	{
		for (int i = 1; i < n + 1; i++)
		{
			try
			{
				System.Console.WriteLine(i);

			}
			catch
			{
				System.Console.WriteLine("no se pudo");
			}
			return n;
		}


	}


}

