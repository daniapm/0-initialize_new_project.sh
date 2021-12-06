using System;
using System.Collections.Generic;
class Dictionary
{
	public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
	{
		bool index = false;
		foreach (KeyValuePair<string, string> entry in myDict)
		{
			if (entry.Key == key)
				index = true;
		}
		if (index == true)
			myDict[key] = value;
		else
			myDict.Add(key, value);
		return myDict;
	}

}