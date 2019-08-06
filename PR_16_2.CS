using System;

public class Test
{
	private static int y = 20;

	public delegate void Del(double x);

	public static void Main()
	{
		int z = 30;

		Del d = delegate(double x)
		{
			Console.WriteLine(x + y + z); 
		};

		F(d);
	}

	public static void F(Del d)
	{
		d(10);
	}
} 
