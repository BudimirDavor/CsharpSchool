using System;
using System.Threading;

class Test
{
	static void Main()
	{
		for(int i=0;i<60;i++)
		{	
			Thread.Sleep(1000);
			Console.WriteLine(i+1);
		}
	}
}
