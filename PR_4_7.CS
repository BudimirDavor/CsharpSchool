using System;

class Test
{
	static void Main()
	{
		int Zbroj = 0, Max = 1000;
		for(int i = 1;i <= Max;i++)
			Zbroj += i;
		Console.WriteLine("Zbroj prvih {0} brojeva je {1}", Max, Zbroj);
	}
}
