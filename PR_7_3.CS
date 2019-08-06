using System;

class Vrijeme
{
	private byte sat = 0, minuta = 0, sekunda = 0;

	public Vrijeme(byte sat, byte minuta, byte sekunda)
	{
		sat = sat;
		minuta = minuta;
		sekunda = sekunda;
	}

	public byte Sat
	{
		get {return sat;}
	}

	public byte Minuta
	{
		get {return minuta;}
	}

	public byte Sekunda
	{
		get {return sekunda;}
	}
}

public class Test 
{
	public static void Main() 
	{
		Vrijeme PetDoDvanaest = new Vrijeme(11, 59, 55);
		Console.WriteLine("{0}:{1}:{2}", PetDoDvanaest.Sat, PetDoDvanaest.Minuta, PetDoDvanaest.Sekunda);
	}
}
