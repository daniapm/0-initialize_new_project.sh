using System;
using System.Collections.Generic;
using System.Linq;

class List
{
	public static int Sum(List<int> myList)
	{
		HashSet<int> set = new HashSet<int>(myList);
		int total = set.Sum();
		return total;
	}

}