using System;

public class Test 
{
	public static double FiboRec(int n)
	{
		return (n == 0 || n == 1) ?  n : FiboRec(n-1) + FiboRec(n-2);
	}

	public static double Fibo(int n)
	{
		int PrviBroj = 0, DrugiBroj = 1;

		while(n-- != 0)
		{
			int Tmp = PrviBroj + DrugiBroj;
			PrviBroj = DrugiBroj;
			DrugiBroj = Tmp;
		}

		return PrviBroj;
	}

	public static void Main() 
	{
		int i = 40;

		DateTime start = DateTime.Now;
		Console.Write("{0}. èlan = {1} ", i, FiboRec(i));
		DateTime end1 = DateTime.Now;
		TimeSpan Int1 = end1 - start;
		Console.WriteLine("izraèunat za " + Int1.Seconds + "." + Int1.Milliseconds + " sec");

		DateTime end2 = DateTime.Now;
		Console.Write("{0}. èlan = {1} ", i, Fibo(i));
		TimeSpan Int2 = end2 - end1;
		Console.WriteLine("izraèunat za " + Int2.Seconds + "." + Int2.Milliseconds + " sec");
	}
}
