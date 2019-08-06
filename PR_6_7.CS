using System;

class Test
{
	public static void Promijeni(out int i)
	{
		i = 11;
		return;
	}

	static void Main() 
	{
		int x;
		Promijeni(out x);
		Console.WriteLine(x);
	}
}
