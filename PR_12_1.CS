using System;
using System.Threading;

class NitBrojeva
{
	private Thread t1;
	private Thread t2;

	public void PozoviNiti()
	{
		ThreadStart Odds = new ThreadStart(NeparniBrojevi);
		ThreadStart Evens = new ThreadStart(ParniBrojevi);

		t1 = new Thread(Odds);
		t2 = new Thread(Evens);

		t1.Start();
		t2.Start();
	}

	public void NeparniBrojevi()
	{
		for(int i=1;i < 100000;i+=2)
			Console.WriteLine(i);
	}

	public void ParniBrojevi()
	{
		for(int i=2;i <= 100000;i+=2)
			Console.WriteLine(i);
	}
}



class Test
{
	static void Main()
	{
		NitBrojeva n = new NitBrojeva();
		n.PozoviNiti();
	}
}
