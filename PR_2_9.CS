using System;

class Test  
{
	public static void Main() 
	{
		int i = 100;
		object o = i;	// Implicitno pretvaranje integer u object
		i = 200;
		Console.WriteLine("Tip int: {0}", i);
		Console.WriteLine("Tip object: {0}", o);
	}
}
