using System;

public class Planet
{
	private readonly double gravity;

	public Planet(double d)
	{
		gravity = d;
	}

	public double Gravity
	{
		get
		{
			return gravity;
		}
	}
}

public class Test 
{
	public static void Main() 
	{
		double Masa = 100;
		Planet Earth = new Planet(9.80665);
		Planet Jupiter = new Planet(22.94756);
		
		double TezinaZemlja = Masa * Earth.Gravity;
		double TezinaJupiter = Masa * Jupiter.Gravity;

		Console.WriteLine("Težina na Zemlji = {0,7:f} N", TezinaZemlja);
		Console.WriteLine("Težina na Zemlji = {0,7:f} N", TezinaJupiter);
	}
}
