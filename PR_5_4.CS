using System;

class TempClass
{
	private static int Counter;

	public TempClass()
	{
		Counter++;
	}

	public int BrojInstanci()
	{
		return Counter;
	}
}

class Test
{
	static void Main() 
	{		
		TempClass x = new TempClass();
		Console.WriteLine(x.BrojInstanci());

		TempClass y = new TempClass();
		Console.WriteLine(y.BrojInstanci());
		
		TempClass z = new TempClass();
		Console.WriteLine(z.BrojInstanci());
	}
}
