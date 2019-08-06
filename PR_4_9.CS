using System;

class Test
{
	static void Main()
	{		
		bool FlagPrim = true;
		const int Max = 1000;
		int BrojPrimova = 0;

		for(int i = 1;i<Max;i++)
		{
			for(int j=2;j<i-1;j++)
				if(i%j == 0)
				{
					FlagPrim = false;
					break;
				}
			if(FlagPrim)
				BrojPrimova++;
			FlagPrim = true;
		}

		Console.WriteLine("Broj prim brojeva do {0} je {1}", Max, BrojPrimova);
	}
}
