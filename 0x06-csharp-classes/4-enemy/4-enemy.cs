using System;

namespace Enemies
{
	class Zombie
	{
		private int health;
		private string name = "(no name)";

		public Zombie()
		{
			health = 0;
		}
		public Zombie(int value)
		{

			if (value >= 0)
			{
				health = value;
			}
			else
			{
				throw new ArgumentException("Health must be greater than or equal to 0");
			}
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public int GetHealth()
		{
			return health;

		}

	}


}