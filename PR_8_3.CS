using System;

public class Test 
{
	public static void Main() 
	{
		sbyte[][] Arr = new sbyte[3][];
		Arr[0] = new sbyte[7];
		Arr[1] = new sbyte[5];
		Arr[2] = new sbyte[9];

		sbyte x = 1;
		for(int i = 0; i<Arr.Length; i++)
			for(int j=0; j<Arr[i].Length; j++)
				Arr[i][j] = x++;

		for(int i = 0; i<Arr.Length; i++)
			Array.Reverse(Arr[i]);
		
		for(int i = 0; i<Arr.Length; i++)
		{
			for(int j=0; j<Arr[i].Length; j++)
				Console.Write(Arr[i][j] + " ");
			Console.WriteLine();
		}
	}
}
