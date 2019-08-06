using System;

public class Test 
{
	public static void Main() 
	{
		int x = 7, y = 5;
		Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", (x += y), (x *= y), (x /= 4), (x -= 2), (x % y));
	}
}
