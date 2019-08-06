using System;
using System.Threading;

public class Test 
{
	public static void Main() 
	{
		int x;
		Random NekiBroj = new Random();
		while((x = NekiBroj.Next(100)) != 50)
			Console.WriteLine(x);
	}
}
