using System;

namespace pointers
{
	
	unsafe class A{
	
		public	int a = 100;
		public	int b = 100;		
	}
	
	unsafe class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			
			int a = 100;
			int* p_a = &a;
			
			changeVal(p_a);
			
			Console.WriteLine(a);
			Console.WriteLine(*p_a);
			Console.ReadKey();
			
			A theA = new A();
			theA.a = 2000;
			//A* p_ac = &theA;
		}
		
		static void changeVal(int* test){
		
			*test = 584693;
			
		}
		
		
	}
}
