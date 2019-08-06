using System;

class Test
{
	static void Main()
	{
		int? x = 4;
		if(x.HasValue)
		{
			Console.WriteLine(x);
			x = null;
		}
       
		try
		{
			int y = x.Value;
		}
		catch (System.InvalidOperationException)
		{
			Console.WriteLine("Varijabla x ima null vrijednost");
		}
	}
}
