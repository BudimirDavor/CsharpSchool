using System;

public class Planet
{
	public const double Gravity = 9.80665;
}

public class Test 
{
	public static void Main() 
	{
		double Masa = 100;
		double Tezina = Masa * Planet.Gravity;

		Console.WriteLine("Težina = " + Tezina + " N");
	}
}
