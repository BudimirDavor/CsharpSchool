using System;
using System.Collections.Generic;

class Test
{
	static void Main()
	{
		int[] ArrInt = {1, 2, 3, 4, 5};
		double[] ArrDouble = {1.5, 2.5, 3.5, 4.5, 5.5};
		string[] ArrString = {"One", "Two", "Three", "Four", "Five"};

		UseGenerics(ArrInt);
		UseGenerics(ArrDouble);
		UseGenerics(ArrString);
	}

	static void UseGenerics <T> (T[] Arr)
	{
		foreach(T el in Arr)
			Console.Write(el + " ");
		Console.WriteLine();
	}
}
