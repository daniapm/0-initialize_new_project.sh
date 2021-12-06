using System;
using System.Collections.Generic;

class Dictionary
{
	public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
	{
		Dictionary<string, int> myDictt = new Dictionary<string, int>();

		foreach (KeyValuePair<string, int> element in myDict)
			myDictt.Add(element.Key, element.Value * 2);
		return myDictt;
	}
}