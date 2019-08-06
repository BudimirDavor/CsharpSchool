using System;

unsafe class Test
{
	private int x = 50;

	static void Main()
	{
		Test t = new Test();
		fixed(int *p = &t.x)
		{
			Console.WriteLine(*p);
			GC.Collect();
			Console.WriteLine(*p);
		}
	}
}
