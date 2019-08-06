using System;
using System.Threading;

class Count
{
	public static int Counter = 100;

	public void Counting1()
	{
		while(Count.Counter > 0)
		{
			int x = Count.Counter;
			x--;
			Thread.Sleep(5);
			Count.Counter = x;
			Console.WriteLine(Count.Counter);
		}
	}

	public void Counting2()
	{
		while(Count.Counter > 0)
		{
			int x = Count.Counter;
			x--;
			Thread.Sleep(5);
			Count.Counter = x;
			Console.WriteLine(Count.Counter);
		}
	}

}

class Test
{
	static void Main()
	{
		Count Odbrojavanje = new Count();
		Thread t1 = new Thread(new ThreadStart(Odbrojavanje.Counting1));
		t1.Start();

		Thread t2 = new Thread(new ThreadStart(Odbrojavanje.Counting2));
		t2.Start();
	}
}
