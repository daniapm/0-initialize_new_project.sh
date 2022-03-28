using System;

class Queue<T>
{

	public Type CheckType()
	{
		return typeof(T);
	}

	public class Node
	{
		private T value;
		public Node next = null;

		public Node(T val)
		{
			value = val;
		}
	}

	public Node head;
	public Node tail;
	public int count;

	public void Enqueue(T value)
	{
		Node newnode = new Node(value);
		if (head == null)
		{
			head = newnode;
			tail = newnode;
		}
		else
		{
			tail.next = newnode;
			tail = newnode;
		}
		count++;
	}

	public int Count()
	{
		return count;
	}
}
