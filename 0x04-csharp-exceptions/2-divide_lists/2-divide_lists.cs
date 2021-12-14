using System;
using System.Collections.Generic;

class List
{
	public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
	{
		List<int> mylist = new List<int>();

		int index = 0;
		while (index < listLength)
		{
			try
			{
				mylist.Add(list1[index] / list2[index]);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Cannot divide by zero");
				mylist.Add(0);
			}
			catch (ArgumentOutOfRangeException)
			{
				Console.WriteLine("Out of range");

			}
			index++;
		}

		return mylist;
	}
}

