using System;

public class Test 
{
	public static long Faktorijel(int n)
	{
		long result;   

		if(n == 1) 
			return 1;  
		result = Faktorijel(n-1)* n;  
		
		return result;  
	}

	public static void Main() 
	{
		int i = 10;
		Console.WriteLine("{0}! = {1}", i, Faktorijel(i));
	}
}
