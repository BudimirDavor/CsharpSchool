using System;

public class Test 
{
	public static void Main() 
	{
		try 
		{	
			Overflow();
		}
		catch(Exception e)
		{ 
			Console.WriteLine("Dodatna obrada iznimke ...");
		}
	}

	public static void Overflow()
	{
		int [] Arr = new int [10];

		try 
		{	
			Arr[10] = 1;
		}
		catch(IndexOutOfRangeException e)
		{ 
			Console.WriteLine("Obrada iznimke ...");
			throw;
		}
	}
}
