using System;
using System.Text;
using System.Threading;


namespace delegates
{
	class MainClass
	{
		 
		delegate void TestDelegate(); 
		
		static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			//We all all the functions in the delegate and play it
			TestDelegate theNewDel = new TestDelegate(print1);
			theNewDel += print2;
			theNewDel += print3;
			theNewDel();
		}
		
		static void print1(){
			
			Console.WriteLine("1");
		}
		
		static void print2(){
			
			Console.WriteLine("2");
		}
		
		static void print3(){
			
			Console.WriteLine("3");
		}
	}
}
