using System;

class Test  
{
	public static void Main() 
	{
		int i = 100;
		object o = i;	
		int j = (int)o;	// Eksplicitno pretvaranje object u integer
		Console.WriteLine("Tip int: {0}", j);
	}
}
