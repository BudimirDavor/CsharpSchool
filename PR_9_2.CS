using System;

public class Test
{
	public delegate void Del(double d);

	public static void Main()
	{
		Del d1 = new Del(F1);
		d1 += new Del(F2);
		d1(5);
		d1 -= new Del(F2);
		d1(6);
	}

	public static void F1(double d)
	{
		Console.WriteLine(d);
	}

	public static void F2(double d)
	{
		Console.WriteLine(d * 2);
	}
}
