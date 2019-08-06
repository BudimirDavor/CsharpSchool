using System;
using System.Collections;

public class Test 
{
	public static void Main() 
	{
		ArrayList Arr = new ArrayList();
		
		for(int i=0;i<7;i++)
			Arr.Add(1);
		
		for(int i=0;i<7;i++)
			Arr.Add(0);

		for(int i=0;i<14;i++)
			Console.Write(Arr[i] + " ");
	}
}
