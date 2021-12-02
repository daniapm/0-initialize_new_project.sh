using System;
using System.Collections.Generic;
class List
{
	public static List<int> DifferentElements(List<int> list1, List<int> list2)
	{
		List<int> total = list1.FindAll(element => !list2.Contains(element));
		List<int> total2 = list2.FindAll(element => !list1.Contains(element));
		total.AddRange(total2);
		total.Sort();
		return total;
	}

}
