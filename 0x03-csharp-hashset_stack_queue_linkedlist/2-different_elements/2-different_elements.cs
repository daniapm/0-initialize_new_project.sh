using System;
using System.Collections.Generic;
using System.Linq;
class List
{
	public static List<int> DifferentElements(List<int> list1, List<int> list2)
	{
		List<int> total = list1.Where(i => !list2.Contains(i)).ToList();
		List<int> total2 = list2.Where(i => !list1.Contains(i)).ToList();
		total.AddRange(total2);
		total.Sort();
		return total;
	}

}
