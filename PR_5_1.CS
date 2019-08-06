using System;

public class Planet
{
	private bool Life;
	private bool Atmosfera;
	private sbyte BrojSatelita;
	private int Promjer;
	private float BrzinaOkoOsi;
	private float BrzinaOkoSunca;
	private string NazivPlaneta;

	public Planet(string name, sbyte brojsat)
	{
		NazivPlaneta = name;
		BrojSatelita = brojsat;
	}

	public Planet(string name, bool life, bool atm)
	{
		NazivPlaneta = name;
		Life = life;
		Atmosfera = atm;
	}

	public Planet(string name, bool life, bool atm, sbyte brojsat, int promjer, float brzina1, float brzina2)
	{
		NazivPlaneta = name;
		Life = life;
		Atmosfera = atm;
		BrojSatelita = brojsat;
		Promjer = promjer;
		BrzinaOkoOsi = brzina1;
		BrzinaOkoSunca = brzina2;		
	}
}

public class Test
{
	static void Main()
	{
		Planet Earth = new Planet("Zemlja", true, true, 1, 6370, 0.463f, 29.7f);
		Planet Mercury = new Planet("Merkur", false, false);
		Planet Mars = new Planet("Mars", 2);
	}
}
