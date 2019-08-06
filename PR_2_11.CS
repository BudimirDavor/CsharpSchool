using System;

class TempClass
{
	private int x;
}


class Test  
{
	public static void Main() 
	{
		int i = 35;
		TempClass Tmp = new TempClass();
		Console.WriteLine(i.ToString());		
		Console.WriteLine(Tmp.ToString());
	}
}
