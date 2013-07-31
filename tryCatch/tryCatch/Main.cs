using System;

namespace tryCatch
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");
			
			//we try the folllowing code  if there is any error we check it out with catch
			try{
				Console.WriteLine(int.Parse("14645123a"));
				
			}
			
			catch{
				Console.Write("Error");
			}
			
		}
	}
}
