using System;
using System.Collections.Generic;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{

		LinkedList<int> linked = new LinkedList<int>();
		if (size < 0)
		{
			return linked;
		}

		for (int i = 0; i < size; i++)
		{
			linked.AddFirst(i);
			Console.WriteLine(i);
		}
		return linked;
	}

}