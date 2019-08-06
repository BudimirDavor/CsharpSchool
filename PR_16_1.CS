using System;

partial class NekaKlasa
{
	private int xVar = 10;
	public int XVar {get {return xVar;}}
}

partial class NekaKlasa
{
	private int yVar = 20;
	public int YVar {get {return yVar;}}
}

class Test
{
	public static void Main()
	{
		NekaKlasa tmp = new NekaKlasa();
		int z = tmp.XVar + tmp.YVar;
		Console.WriteLine(z);
	}
}
