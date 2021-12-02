using System;
using System.Collections.Generic;
class LList
{
	public static int FindNode(LinkedList<int> myLList, int value)
	{
		int valor = 0;
		for (int element = 0; element < myLList.Count; element++)
		{
			if (element == value)
			{
				return (valor);
			}
		}
		return (-1);
	}
}