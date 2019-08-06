using System;

public class Test 
{
	public static void Main() 
	{
		int Eksponent = 6;
		string Tekst;

		switch(Eksponent)
		{
			case -12:
				Tekst = "piko";
				break;
			case -9:
				Tekst = "nano";
				break;
			case -6:
				Tekst = "mikro";
				break;
			case -3:
				Tekst = "mili";
				break;
			case 3:
				Tekst = "kilo";
				break;
			case 6:
				Tekst = "mega";
				break;
			case 9:
				Tekst = "giga";
				break;
			case 12:
				Tekst = "tera";
				break;
			default:
				Tekst = Eksponent < 0  ? "Premala velièina" : "Prevelika velièina";
				break;
		}

		Console.WriteLine(Tekst);
	}
}
