using System;
using System.Collections.Generic;
using System.Linq;
class List
{
	public static List<int> CommonElements(List<int> list1, List<int> list2)
	{

		List<int> total = list1.FindAll(element => list2.Contains(element));
		return total;
	}

}
