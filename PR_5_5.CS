using System;

class TempClass
{
	public int X;

	static TempClass()
	{
		Console.WriteLine("Statièki konstruktor");
	}

	public TempClass(int x)
	{
		X = x;
		Console.WriteLine("Kreiranje objekta");
	}
}

class Test
{
	static void Main() 
	{		
		Console.WriteLine("Prije kreiranja objekta");
		TempClass x = new TempClass(5);
		Console.WriteLine("Poslije kreiranja objekta");
	}
}
