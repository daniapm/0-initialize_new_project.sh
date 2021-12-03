using System;
using System.Collections.Generic;
class LList
{
	public static int Sum(LinkedList<int> myLList)
	{
		int suma = 0;
		foreach (int item in myLList)
		{
			suma = suma + item;

		}
		suma++;

		return suma;
	}

}