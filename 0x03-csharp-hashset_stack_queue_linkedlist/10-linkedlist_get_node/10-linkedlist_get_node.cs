﻿using System;
using System.Collections.Generic;

class LList
{
	public static int GetNode(LinkedList<int> myLList, int n)
	{
		int element = 0;
		foreach (int item in myLList)
		{
			if (element == n)
			{
				return item;


			}
			element++;
		}
		return 0;
	}
}