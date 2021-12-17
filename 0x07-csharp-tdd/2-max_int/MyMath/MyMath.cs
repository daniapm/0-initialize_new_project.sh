using System;
using System.Collections.Generic;

namespace MyMath
{
	public class Operations
	{
		public static int Max(List<int> nums)
		{
			if (nums.Count == 0)
			{
				return 0;

			}
			else
			{
				int last = nums[nums.Count - 1];
				return last;
			}

		}
	}
}
