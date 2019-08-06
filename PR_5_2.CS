using System;

public class Planet
{
	private bool Life;
	public bool Atmosfera;
	private string NazivPlaneta;

	public Planet(string name, bool life, bool atm)
	{
		NazivPlaneta = name;
		Life = life;
		Atmosfera = atm;
	}

	public void PromijeniLife(bool life)
	{
		Life = life;
	}

}

public class Test
{
	static void Main()
	{
		Planet Uranus = new Planet("Uran", false, true);
	}
}
