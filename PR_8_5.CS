using System;
using System.Collections;

public class CollectionClass 
{
	double [] Elementi;

	public CollectionClass() 
	{
		Elementi = new double[] { 1.1, 2.2, 3.3, 4.4 };
	}

	public EnumeratorClass GetEnumerator() 
	{
		return new EnumeratorClass(this);
	}
 
	public class EnumeratorClass
	{
		int Ind = -1;
		CollectionClass Kolekcija;

		public EnumeratorClass(CollectionClass Kolekcija) 
		{
			this.Kolekcija = Kolekcija;
		}

		public double Current 
		{
			get 
			{
				return(Kolekcija.Elementi[Ind]);
			}
		}

		public bool MoveNext() 
		{
			Ind++;
			return Ind < Kolekcija.Elementi.Length;
		}
	}
}

public class Test
{
	public static void Main() 
	{
		CollectionClass col = new CollectionClass();

		foreach(double d in col) 
			Console.WriteLine(d);
	}
}
