using System;

public class Test 
{
	public static void Main() 
	{
		int x = 1;
		string tekst;
	
		if(x >= 0)
		if(x == 0)
			tekst = "x je 0";
		else
			tekst = "x je ve�i od 0";
		else
			tekst = "x je manji od 0";

		Console.WriteLine(tekst);
	}
}
