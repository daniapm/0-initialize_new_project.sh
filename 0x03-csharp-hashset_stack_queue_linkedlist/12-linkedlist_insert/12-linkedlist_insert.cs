using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> dummy = myLList.First;
		if (dummy != null)
		{
			if (n < dummy.Value)
			{
				return myLList.AddBefore(dummy, n);
			}
			dummy = dummy.Next;
		}
		return myLList.AddLast(n);
	}

}