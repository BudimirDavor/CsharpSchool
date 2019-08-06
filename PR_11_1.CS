using System;

public class Test 
{
	[Obsolete("Metoda FCPlusPlus je zastarjela, koristite FCSharp", true)]
	static void FCPlusPlus() 
	{
		//int *Arr = (int *) malloc(100 * sizeof(int));
	}
   
	static void FCSharp() 
	{ 
		int [] Arr = new int[100];
	}
   
	public static void Main() 
	{
		FCPlusPlus();
	}
}
