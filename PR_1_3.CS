using System;

public class Test
{
	public static void Main(string[] Args)
	{
		if(Args.Length != 2)
			return;
		int R1 = System.Convert.ToInt32(Args[0]);
		int R2 = System.Convert.ToInt32(Args[1]);
		
		Console.WriteLine("{0} Ohm", R1 * R2 / (R1 + R2)); 
	}
}
