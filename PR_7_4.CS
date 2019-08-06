using System;

class Vrijeme
{
	private byte sat = 0, minuta = 0, sekunda = 0;
	
	public Vrijeme(byte sat, byte minuta, byte sekunda)
	{
		this.sat = sat;
		this.minuta = minuta;
		this.sekunda = sekunda;		
	}

	public void SetTime(Time t)
	{
		t.ChangeTime(this);
	}

	public byte Sat {get {return sat;}}
	public byte Minuta {get {return minuta;}}
	public byte Sekunda {get {return sekunda;}}
}

class Time
{
	private byte sat = 0, minuta = 0, sekunda = 0;

	public void ChangeTime(Vrijeme v)
	{
		sat = v.Sat;
		minuta = v.Minuta;
		sekunda = v.Sekunda;
		Console.WriteLine("{0}:{1}:{2}", Sat, Minuta, Sekunda);
	}

	public byte Sat {get {return sat;}}
	public byte Minuta {get {return minuta;}}
	public byte Sekunda {get {return sekunda;}}
}

public class Test 
{
	public static void Main() 
	{
		Vrijeme PetDoDvanaest = new Vrijeme(11, 59, 55);
		Time NoTime = new Time();
		PetDoDvanaest.SetTime(NoTime);
	}
}
