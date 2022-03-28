using System;

class Queue<T>
{

	public Type CheckType()
	{
		return typeof(T);
	}

	public class Node
	{
		public T value;
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

    public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			tail.value = head.value;
			head = head.next;
			count--;
			return tail.value;
		}
	}

    public T Peek() {
        if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
        else {
            return head.value;
        }
    }

    public void Print() {
        if (head == null)
		{
			Console.WriteLine("Queue is empty");
        }
        else {
        tail = head;
        while(tail != null)
        {
			Console.WriteLine(tail.value);
            tail = tail.next;
        }
        }
    }

    public void Concatenate() {
        if (head == null)
		{
			Console.WriteLine("Queue is empty");
            return null;
        }
        else if (!(typeof(T) == typeof(String) || typeof(T) == typeof(Char)))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
            return null;
        }
        else {
			int count_index = 0;
            string newString = "";
            tail = head;

            if (typeof(T) == typeof(char))
            {
                while(tail != null)
                {
			        newString += tail.value;
                    tail = tail.next;
                }
            }
            
            else if (typeof(T) == typeof(string))
			{
				while (tail != null)
				{
                    if(count_index != 0)
                        newString += " ";    
					newString += tail.value;
					tail = tail.next;
                    count_index++;
				}
			}
            return newString;
		}
            
    }
}
