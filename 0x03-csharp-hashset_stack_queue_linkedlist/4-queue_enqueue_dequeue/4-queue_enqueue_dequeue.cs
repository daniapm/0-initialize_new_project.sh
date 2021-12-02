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

		Console.WriteLine($"Number of items: {aQueue.Count}");
		Console.WriteLine($"Top item: {aQueue.Peek()}");
		if (aQueue.Contains(search))
		{
			Console.WriteLine($"Queue contains \"{search}\": True");
			while (aQueue.Dequeue() != search) ;
		}
		else
		{
			Console.WriteLine($"Queue contains \"{search}\": False");
		}
		aQueue.Enqueue(newItem);
		return aQueue;
	}

}