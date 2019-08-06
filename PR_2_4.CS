using System;

class Test
{
	static void Main() 
	{
		int x = 10;
		for(int y=0;y<10;y++)
		{
			int z = 20;
		}
		// Console.WriteLine("y = " + y);   // Ovo se neæe prevesti
		// Console.WriteLine("z = " + z);   // Ovo se neæe prevesti
		Console.WriteLine("x = " + x);      // OK
	}
}
