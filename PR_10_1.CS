using System;
using System.Threading;

public class Test 
{
	public static void Main() 
	{
		int x = 1;
		Random r = new Random();

		for(int i = 0;i<100;i++)
		{
			int y = r.Next(100);
		
			try 
			{
				int z = x/y;
			}
			catch(Exception e)
			{
				Console.WriteLine("Pokušaj dijeljenja s nulom");
			}
		}
	}
}
