using System;
using System.Collections.Generic;

public class CollectionClass 
{
	double [] Elementi;

	public CollectionClass() 
	{
		Elementi = new double[] { 1.1, 2.2, 3.3, 4.4 };
	}

	public IEnumerator<double> GetEnumerator()
	{
		foreach(double d in Elementi)
			yield return d;
	}
}

class Test
{
	public static void Main()
	{
		CollectionClass Arr = new CollectionClass();

		foreach(double d in Arr)
			Console.WriteLine(d);
	}
}
