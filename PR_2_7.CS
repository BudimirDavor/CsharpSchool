using System;

class TempClass
{
	public int Counter;

	public TempClass(int x)
	{
		Counter = x;
	}
}

class Test
{
	static void Main() 
	{
		int Val = 5;
		Console.WriteLine("Prije poziva funkcije: " + Val);
		PromijeniVal(Val);
		Console.WriteLine("Poslije poziva funkcije: " + Val);
		Console.WriteLine();
	
		TempClass Ref = new TempClass(5);
		Console.WriteLine("Prije poziva funkcije: " + Ref.Counter);
		PromijeniRef(Ref);
		Console.WriteLine("Poslije poziva funkcije: " + Ref.Counter);
	}

	public static void PromijeniVal(int Value)
	{
		Value = 10;
	}

	public static void PromijeniRef(TempClass Ref)
	{
		Ref.Counter = 10;
	}
}
