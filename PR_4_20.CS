using System;

public class Test 
{
	public static void Main() 
	{
		int i, j=0;
		bool Flag = false;

		for(i = 0;i<100 && !Flag;i++)
		{
			for(j = 0;j<100;j++)
			{
				if(i + j == 10)
				{
					Flag = true;
					break;
				}
			}
		}
		Console.WriteLine("{0} {1}", --i, j); // i æe biti poveæan nakon break, pa ga treba smanjiti za 1
	}
}
