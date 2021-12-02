using System;
using System.Collections.Generic;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		if (aQueue.Count <= 0)
		{
			Console.WriteLine("Stack is empty");
		}
		else
		{
			Console.WriteLine($"Number of items: {aQueue.Count}");

		}
		Console.WriteLine($"Top item: {aQueue.Peek()}");
		if (aQueue.Contains(search))
		{
			Console.WriteLine($"Stack contains \"{search}\": True");
			while (aQueue.Dequeue() != search) ;
		}
		else
		{
			Console.WriteLine($"Stack contains \"{search}\": False");
		}
		aQueue.Enqueue(newItem);
		return aQueue;
	}

}