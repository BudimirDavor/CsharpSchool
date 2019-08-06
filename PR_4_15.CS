using System;

public class Test 
{
	public static void Main() 
	{
		int i;
		long Faktorijel = 1;

		for(i = 1;i<100;i++)
		{
			if(Faktorijel > 1000000)
			{
				Faktorijel /= (i-1);
				break;
			}
			Faktorijel *= i;
		}
		Console.WriteLine("{0}! = {1}", i-2, Faktorijel);
	}
}
