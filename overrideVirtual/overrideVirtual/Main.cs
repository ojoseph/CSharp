using System;

namespace overrideVirtual
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			a theB = new b();
			theB.run();
			Console.ReadKey();
		}
	}
	
	
	class a{
		public virtual void run(){
			Console.WriteLine("run from a");
		}
	}
	
	class b : a{
		public override void run ()
		{
				Console.WriteLine("this is from B");
			base.run ();
		}
		
	}
	
	
}
