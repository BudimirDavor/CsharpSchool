using System;
using System.Threading;

public class Test 
{
	public static void Main() 
	{
		Random NekiBroj = new Random();

		while(NekiBroj.Next(100) != 50)
			;
	}
}
