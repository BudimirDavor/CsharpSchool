using System;

class Test  
{
	public static void Main() 
	{
		String str = String.Format("{0} {1}", "hello", "world");
		Console.WriteLine(str);
	
		int n = 2;
		str = String.Format("{0} {1} {2:d}. {3}", "hello", "world", n, "put");
		Console.WriteLine(str);
		
		double CijenaKabela = 500.68;
		str = String.Format("{0,-20} {1,7:f}", "Cijena kabela je", CijenaKabela);
		Console.WriteLine(str);

		double CijenaUticnice = 15.68;
		str = String.Format("{0,-20} {1,7:f}", "Cijena utiènice je", CijenaUticnice);
		Console.WriteLine(str);

		str = String.Format("{0} {1:c}", "Cijena kabela je", CijenaKabela);
		Console.WriteLine(str);

		str = String.Format("{0} {1:d}", "Danas je", DateTime.Now);
		Console.WriteLine(str);
		str = String.Format("{0} {1:d}. {2}", "Danas je", DateTime.Now.DayOfYear, "dan u godini");
		Console.WriteLine(str);
	}
}

