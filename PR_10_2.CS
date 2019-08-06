using System;
using System.Threading;

public class Test 
{
	public static void Main() 
	{
		int x = 1, y = 0, z;
		string [] Desetoboj = new string [] {"100 m", "Skok u dalj",
				"Bacanje kugle", "Skok u vis", "400 m",
				"110 m prepone", "Bacanje diska", "Skok s motkom",
				"Bacanje koplja", "1500 m"};

		Random r = new Random();

		try 
		{	
			if(r.Next(2) == 0)
				Desetoboj[10] = "Maraton";				
			else
				z = x / y;			
		}
		catch(Exception e)
		{ 
			Console.WriteLine(e.Message);
		}
	}
}
