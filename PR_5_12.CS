using System;

struct SKoordinate 
{
	public int XCoord, YCoord;

	public SKoordinate(int x, int y) 
	{
		XCoord = x;
		YCoord = y;
	}
}

class CKoordinate 
{
	public int XCoord, YCoord;

	public CKoordinate(int x, int y) 
	{
		XCoord = x;
		YCoord = y;
	}
}

class MainClass 
{
	public static void PromijeniXYs(SKoordinate sTmp)
	{
		sTmp.XCoord = 100;
		sTmp.YCoord = 200;
	}

	public static void PromijeniXYc(CKoordinate cTmp)
	{
		cTmp.XCoord = 100;
		cTmp.YCoord = 200;
	}

	public static void Main()  
	{
		SKoordinate s = new SKoordinate(800, 600);		
		CKoordinate c = new CKoordinate(1024, 768);
		
		PromijeniXYs(s);
		PromijeniXYc(c);
		
		Console.WriteLine(s.XCoord + ", " + s.YCoord);
		Console.WriteLine(c.XCoord + ", " + c.YCoord);
	}
}
