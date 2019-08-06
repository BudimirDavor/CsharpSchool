using System;

public class Test 
{
	public static void Main() 
	{
		int i, j=0;
		for(i = 0;i<100;i++)
		{
			for(j = 0;j<100;j++)
			{
				if(i + j == 10)
					break;
			}
		}
		Console.WriteLine("{0} {1}", i, j); 
	}
}
