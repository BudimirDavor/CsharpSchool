using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public class AutorAttribute : Attribute
{
	protected string autor;
	protected double verzija;
	protected string vrstaPosla;

	public AutorAttribute(string autor, double verzija)
	{
		this.autor = autor;
		this.verzija = verzija;
	}

	public string Autor
	{
		get {return autor;}
	}
	
	public double Verzija
	{
		get {return verzija;}
	}

	public string VrstaPosla
	{
		get {return vrstaPosla;}
		set {vrstaPosla = value;}
	}
}

public class OKCorral
{	
	private int numberOfBullets = 100;
	private int numberOfClantons = 4;

	[Autor("Wyatt Earp", 1.0, VrstaPosla = "Testiranje")]
	public void ShotByGun()
	{
		numberOfBullets--;
		if((numberOfBullets % 2) == 0)
			numberOfClantons--;
	}

	[Autor("Doc Holliday", 1.0, VrstaPosla = "Programiranje")]
	public void ShotByColt()
	{
		numberOfBullets--;
		numberOfClantons--;
	}

	[Autor("Wyatt Earp", 2.0)]
	public int NumberOfBullets
	{
		get {return numberOfBullets;}
	}

	[Autor("Wyatt Earp", 2.0)]
	[Autor("Doc Holliday", 2.1, VrstaPosla = "Programiranje")]
	public int NumberOfClantons
	{
		get {return numberOfClantons;}
	}
}


public class Test 
{
	public static void Main() 
	{
		Type t = typeof(OKCorral);
		AutorAttribute Aut;

		foreach(MethodInfo metoda in t.GetMethods())
		{
			bool Flag = false;
			foreach(Attribute attr in metoda.GetCustomAttributes(true))
			{
				Aut = attr as AutorAttribute;
				if(Aut != null)
				{
					if(!Flag)
						Console.WriteLine(metoda.MemberType + " " + metoda.Name);
					Console.WriteLine("Autor: {0};  Verzija: {1:f};  {2}", Aut.Autor, Aut.Verzija, Aut.VrstaPosla);
					Flag = true;
				}
			}
			if(Flag)
				Console.WriteLine();
		}
		
		foreach(PropertyInfo svojstvo in t.GetProperties())
		{
			bool Flag = false;
			foreach(Attribute attr in 
				svojstvo.GetCustomAttributes(true))
			{
				Aut = attr as AutorAttribute;
				if(Aut != null)
				{
					if(!Flag)
						Console.WriteLine(svojstvo.MemberType + " " + svojstvo.Name);
					Console.WriteLine("Autor: {0};  Verzija: {1:f};  {2}", Aut.Autor, Aut.Verzija, Aut.VrstaPosla);
					Flag = true;
				}
			}
			if(Flag)
				Console.WriteLine();
		}
	}	
}
