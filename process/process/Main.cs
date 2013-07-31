using System;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace process
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine(Process.GetCurrentProcess().ProcessName);
			Process.GetCurrentProcess().Refresh();
			Console.ReadKey();
		}
	}
}
