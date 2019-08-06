using System;

public class Girl
{
	private int visina;
	private DateTime datumR;

	public Girl(int i, DateTime d)
	{
		visina = i;
		datumR = d;
	}

	public int Visina
	{
		get 
		{ 
			return visina;
		}
	}

	public DateTime DatumR
	{
		get 
		{
			return datumR;
		}
	}
}
 
public class Test
{
	public delegate int Sortiranje(Girl o1, Girl o2);

	public static void Main()
	{
		Sortiranje d1 = new Sortiranje(PoVisini);
		Sortiranje d2 = new Sortiranje(PoDatumu);
         
		PozivPoDelegatu(d1);
		PozivPoDelegatu(d2);
	}

	public static int PoVisini(Girl o1, Girl o2)
	{
		return o1.Visina <  o2.Visina ? -1 : 
                   o1.Visina == o2.Visina ?  0 : 1;
	}

	public static int PoDatumu(Girl o1, Girl o2)
	{
		return o1.DatumR <  o2.DatumR ? -1 : 
 		       o1.DatumR == o2.DatumR ?  0 : 1;
	}

	public static void PozivPoDelegatu(Sortiranje Met)
	{
		Girl Ivana = new Girl(125, new DateTime(2000, 6, 24));
		Girl Jelena = new Girl(110, new DateTime(2002, 11, 21));
		
		int Ret = Met(Ivana, Jelena);
		Console.WriteLine(Ret < 0 ? "Ivana < Jelena" : 
			Ret == 0 ? "Ivana == Jelena" : "Ivana > Jelena");
	}
}
