using System;

class TempClass
{
	public void MethodOne(int i)
	{
		Console.WriteLine(i);
	}

	public void MethodOne(double d)
	{
		Console.WriteLine(d);
	}

	public void MethodOne(double d1, double d2)
	{
		Console.WriteLine(d1 * d1 + d2 * d2);
	}

	public void MethodOne(string s)
	{
		Console.WriteLine(s);
	}
}

class Test
{
	static void Main() 
	{
		int i = 10;
		TempClass x = new TempClass();
		x.MethodOne(i);
		x.MethodOne(40.67);
		x.MethodOne(6, 8);
		x.MethodOne("hello, world");
	}
}
