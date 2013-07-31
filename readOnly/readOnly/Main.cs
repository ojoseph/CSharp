using System;

namespace readOnly
{
	class MainClass
	{
		//Read only memory
		static readonly int test = 10;
		
		public static void Main (string[] args)
		{
			
			//test = 15;
			Console.WriteLine(test);
			
			Console.WriteLine ("Hello World!");
		}
	}
}
