using System;

public delegate void Signal(int v, long b);

class Operater
{
	public event Signal Signalizirano;
	
	public void DolazniSignal(int vrsta, long broj)
	{
		Signalizirano(vrsta, broj);
	}
}

class MobilePhone
{
	public MobilePhone(Operater Sig)
	{
		Sig.Signalizirano += new Signal(SignalStigao);
	}

	private void SignalStigao(int vrsta, long broj)
	{
		if(vrsta == 0)
			Console.WriteLine("Stigao poziv od broja " + broj);
		else
			Console.WriteLine("Stigao SMS od broja " + broj);
	}
}

public class Test 
{
	public static void Main() 
	{
		Operater r = new Operater();
		MobilePhone SE = new MobilePhone(r);

		r.DolazniSignal(0, 38521100000);
		r.DolazniSignal(1, 38521200000);
	}
}
