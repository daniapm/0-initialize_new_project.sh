using System;
class Line
{
	public static void PrintLine(int length)
	{
		int i = 0;
		for (i = 0; i < length; i++)
		{
			if (length <= 0)
			{
				Console.Write("\n");
			}
			else
			{
				Console.Write("_");

			}
		}
		Console.Write("\n");

	}
}

