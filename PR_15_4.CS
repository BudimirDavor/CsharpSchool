using System;

/// <summary>
/// Klasa za rad s temperaturama
/// </summary>
/// <remarks>
/// Klasa Celzius nema definiran konstruktor. 
/// Temperatura se zadaje preko svojstva
/// </remarks>

class Celzius
{
	/// <summary>
	/// Varijabla sadržava trenutnu temperaturu 
	/// koja se zadaje preko svojstva
	/// </summary>
	private double trenutnaTemperatura;
	
	/// <summary>
	/// Get/Set svojstvo za varijablu trenutnaTemperatura
	/// </summary>
	/// <value>
	/// Vrijednost koja se zadaje mora biti tipa double
	/// </value>
	public double TrenutnaTemperatura
	{
		get
		{
			return trenutnaTemperatura;
		}
		
		set
		{
			trenutnaTemperatura = value;
		}
	}

	/// <summary>
	/// Metoda vraæa vrijednost temperature u Kelvinima 
	/// za zadanu vrijednost u Celziusima
	/// </summary>
	/// <param name="TempCelzius"> Temperatura koja se 
	/// pretvara u Kelvine
	/// </param>
	/// <returns>
	/// Vraæa se double vrijednost temperature u Kelvinima
	/// </returns>

	public double Kelvins(double TempCelzius)
	{
		return TempCelzius + 273.15;
	}
}

class Test
{
	public static int Main()
	{
		Celzius t = new Celzius();
		t.TrenutnaTemperatura = 25;
		Console.WriteLine(t.Kelvins(26.85) + " K");
		return 0;
	}
}
