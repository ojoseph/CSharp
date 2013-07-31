using System;

namespace refOut
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int theA = 100;
			int theO = null;
			Console.WriteLine(theA);
			
			//Pass the reference of A in the memory
			changeI(ref theA);
			Console.WriteLine(theA);
			Console.ReadKey();
			//Console.WriteLine ("Hello World!");
		}
		
		//Pass down the refereen of the memory
		static void changeI(ref int theInt){
			theInt = 100000;
			
		}
		
		
		
		//Pass down the refereen of the memory
		static void changeO(out int theInt){
			theInt = 100000;
			
		}
	}
}
