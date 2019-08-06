using System;

class TablicaM
{
	private int[,] Tab;
	private int DimX, DimY;

	public TablicaM(int x, int y)
	{
		DimX = x;
		DimY = y;
		Tab = new int[x, y];

		for(int i=0;i<x;i++)  
			for(int j=0;j<y;j++)
				Tab[i, j] = (i+1) * (j+1);
	}

	public int Pomnozi(int x, int y)
	{
		if(x >= 1  &&  x <= DimX  && y >= 1  &&  y <= DimY)
			return Tab[x-1, y-1];
		else
			return 0;
	}
}

public class Test 
{
	public static void Main() 
	{
		TablicaM x = new TablicaM(100, 100);
		Console.WriteLine(x.Pomnozi(47, 74));
	}
}
