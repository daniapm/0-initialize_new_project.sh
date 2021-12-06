using System;
using System.Collections.Generic;

class Dictionary
{
	public static void PrintSorted(Dictionary<string, string> myDict)
	{
		SortedList<string, string> sortedkeys = new SortedList<string, string>(myDict);
		foreach (KeyValuePair<string, string> element in sortedkeys)
			Console.WriteLine($"{element.Key}: {element.Value}");
	}
}