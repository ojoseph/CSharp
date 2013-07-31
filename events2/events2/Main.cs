using System;

namespace events
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			
			
			classA theA = new classA();
			theA.OnChange += new EventHandler(theA_OnChange);
			Console.ReadKey();
		}
		
		
		static void theA_OnChange(object sender, EventArgs e){
			
			Console.WriteLine("are you serious?");
			
		}
	}
	
	
	public class classA
	{
		public event EventHandler OnChange;
		
		public void change ()
		{
			
			OnChange(this, new EventArgs());
		}
	}
}
