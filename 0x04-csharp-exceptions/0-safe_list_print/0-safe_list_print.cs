using System;
using System.Collections.Generic;

class List
{
	public static int SafePrint(List<int> myList, int n)
	{
		for (int i = 1; i < n; i++)
		{
			try
			{
				System.Console.WriteLine(i);

			}
			catch
			{
				return i;
			}
			return i;
		}


	}


}

