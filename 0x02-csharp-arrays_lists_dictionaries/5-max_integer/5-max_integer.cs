﻿using System;
using System.Collections.Generic;
class List
{
	public static int MaxInteger(List<int> myList)
	{
		if (myList.Count - 1 < 0)
		{
			System.Console.WriteLine("List is empty");
		}
		int last = 0;
		for (int i = 0; i < myList.Count; i++)
		{
			myList.Sort();
			last = myList[myList.Count - 1];
		}
		return last;
	}

}
