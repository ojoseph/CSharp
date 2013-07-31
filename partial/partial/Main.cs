using System;

namespace partial
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			newPartClass thing = new newPartClass();
			thing.sega = 10;
		}
	}
	
	//Allows the class to be splitted/used in 2 different places.
	partial class newPartClass{
		public int sega = 0;
	}
	
}
