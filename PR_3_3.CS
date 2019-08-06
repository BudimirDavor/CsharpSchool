using System;

public class Test 
{
	public static void Main() 
	{
		double Result, Kut = Math.PI / 6;
		Result = Kut < Math.PI ? Math.Sin(Kut) : Math.Sin(Kut);
		
		Console.WriteLine(Result);
	}
}
