using System;
using System.Threading;

public class Test 
{
	public static void Main() 
	{
		bool FlagImportant = false;
		Random NekiBroj = new Random();

		do	
		{
			if(!FlagImportant)
			{
				FlagImportant = !FlagImportant;
				// . . . Vrlo va�ne naredbe
			}
			// . . .
		} while(NekiBroj.Next(100) != 50);
	}
}
