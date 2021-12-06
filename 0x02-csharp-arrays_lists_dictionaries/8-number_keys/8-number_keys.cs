using System;
using System.Collections.Generic;
class Dictionary
{
	public static int NumberOfKeys(Dictionary<string, string> myDict)
	{
		int contdor = 0;
		foreach (var keys in myDict)
		{
			contdor = contdor + 1;

		}
		return contdor;


	}
}