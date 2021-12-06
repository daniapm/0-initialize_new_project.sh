using System;
using System.Collections.Generic;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		int val = 0;
		string keys = "";

		if (myList.Count == 0)
		{
			return "None";
		}
		foreach (KeyValuePair<string, int> element in myList)
		{
			if (element.Value >= val)
			{
				val = element.Value;
				keys = element.Key;
			}
		}
		return keys;
	}
}