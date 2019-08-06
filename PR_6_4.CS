using System;

class Test
{
	public static void Promijeni(int i)
	{
		i = 11;
		return;
	}

	static void Main() 
	{
		int x = 10;
		Console.WriteLine(x);
		Promijeni(x);
		Console.WriteLine(x);
	}
}
