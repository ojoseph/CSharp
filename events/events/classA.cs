using System;

namespace Hello_world
{
	public class classA
	{
		public event EventHandler OnChange;
		
		public void change ()
		{
			
			
			OnChange(this, new EventArgs());
			
			
		}
	}
			
			
		
	
}

