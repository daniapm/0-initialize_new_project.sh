using System;
using System.Collections.Generic;
class LList
{
	public static int FindNode(LinkedList<int> myLList, int value)
	{
		int valor = 0;
		foreach (int element in myLList)
		{
			if (element == value)
			{
				return (valor);
			}
			valor++;
		}
		return (-1);
	}
}