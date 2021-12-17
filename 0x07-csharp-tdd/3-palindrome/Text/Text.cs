using System;
using System.Linq;

namespace Text
{
	public class Str
	{
		public static bool IsPalindrome(string s)
		{
			int length = s.Length;
			string str = s.ToLower();
			for (int i = 0; i < length / 2; i++)
			{
				if (str[i] != str[length - i - 1])
					return false;
			}
			return true;
		}
	}

}