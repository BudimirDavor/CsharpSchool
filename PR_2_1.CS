using System;

class TempClass
{
	public int Count = 0;
}

class Test
{
	static void Main() 
	{
		int ValTip1 = 10;
		int ValTip2 = ValTip1;
		ValTip2 = 100;
		TempClass RefTip1 = new TempClass();
		TempClass RefTip2 = RefTip1;
		RefTip2.Count = 100;

		Console.WriteLine("{0}, {1}", ValTip1, ValTip2);
		Console.WriteLine("{0}, {1}", RefTip1.Count, RefTip2.Count);
	}
}
