using System;

public class Planet
{
	private bool life;
	private bool atmosfera;
	private string NazivPlaneta;

	public Planet(string name, bool lf, bool atm)
	{
		NazivPlaneta = name;
		life = lf;
		atmosfera = atm;
	}

	public bool Life
	{
		get
		{
			return life;
		}

		set
		{
			life = value;
		}
	}
}

public class Test
{
	static void Main()
	{
		Planet Uranus = new Planet("Uran", false, true);
		Uranus.Life = true;
		Console.WriteLine("Na Uranu {0} života", Uranus.Life == true ?  "ima" : "nema");
	}
}
