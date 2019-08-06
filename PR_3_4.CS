using System;

public class Test 
{
	public static void Main() 
	{
		for(int i = 1900; i <= 2100; i++)
			if((i % 400 == 0) || (i % 4 == 0  &&  i % 100 != 0))
				Console.WriteLine(i + " je prijestupna");
			else
				Console.WriteLine(i + " nije prijestupna");
	}
}
