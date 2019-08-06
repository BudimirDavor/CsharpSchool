using System;

public class Test 
{
	public static void Main() 
	{
		sbyte x = 127, y;

		try
		{
			y = checked(++x);
		}
		catch(OverflowException e)
		{
			y = x;
		}
		Console.WriteLine(y);
	}
}
