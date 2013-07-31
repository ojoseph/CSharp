using System;
using System.Threading;

namespace threads
{
	class MainClass
	{
		static List<int> lstNum = new List<int>();
		static List<Thread> lstthreads = new List<Thread>();
		
		public static void Main (string[] args)
		{
			lstthreads.Add(new Thread(run));
			lstthreads[0].Start();
			while(true){
				Console.Clear();
				Console.WriteLine(lstNum.Count);
			}
			Console.WriteLine ("Hello World!");
		}
		
		
		static void run(){
			for(int uite = 0; uite < 1000; uite ++){
				lstNum.Add(uite);
			}
		}
		
	}
}
