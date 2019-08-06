using System;

class F1Exception : ApplicationException
{
	public F1Exception(string Message) : base(Message)
	{
}
}

class F1
{
	public void UnesiParametar()
	{
		try 
		{
			double d = Convert.ToDouble(Console.ReadLine());
			PodesiMotor(d);
		}
		catch (F1Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}

	public static void PodesiMotor(double d) 
	{
		if(d < 50  ||  d > 60)
		{
			F1Exception f1 = new F1Exception("Štedi gorivo, ne mogu podesiti motor");
			throw(f1);
		}
		else
			Console.WriteLine(d + " je OK");
	}   
}

class Test
{
	public static void Main() 
	{
		F1 Renault = new F1();	
		Renault.UnesiParametar();
	}
}
