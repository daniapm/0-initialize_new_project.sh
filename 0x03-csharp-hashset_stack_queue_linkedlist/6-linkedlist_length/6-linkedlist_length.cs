using System;
using System.Collections.Generic;

class LList
{
	public static int Length(LinkedList<int> myLList)
	{
		var suma = 0;
		for (int i = 0; i < myLList.Count; i++)
		{
			suma++;

		}
		return suma;
	}

}