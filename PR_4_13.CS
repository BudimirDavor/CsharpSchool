using System;
using System.Threading;

public class Test 
{
	public static void Main() 
	{
		bool FlagImportant = false;
		Random NekiBroj = new Random();

		while(NekiBroj.Next(100) != 50)
		{
			if(!FlagImportant)
			{
				FlagImportant = !FlagImportant;
				// . . . Vrlo važan kôd
			}
			// . . .
		}
	}
}
