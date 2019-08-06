using System;
using System.Threading;
using System.IO;

class Test
{
	public static void Main()
	{
		string Spices = "Spice Girls";
		string [] SpiceGirls = {"Melanie", "Geri", "Victoria", "Emma", "Melanie"};
		DirectoryInfo dir = new DirectoryInfo(Spices);
		
		if(dir.Exists == false)
			dir.Create();
		foreach(string s in SpiceGirls)
			dir.CreateSubdirectory(s);

		Console.WriteLine("Provjerite jesu li mape kreirane prije nego što se izbrišu.");
		Thread.Sleep(20000);
		dir.Delete(true);
	}
}
