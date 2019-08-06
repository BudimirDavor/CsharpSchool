using System;

class KompleksniBroj
{
	private double Real;
	private double Imagine;
	
	public KompleksniBroj(double Real, double Imagine)
	{
		this.Real = Real;
		this.Imagine = Imagine;
	}

	public static KompleksniBroj operator +(KompleksniBroj i1, KompleksniBroj i2) 
	{
		KompleksniBroj x = new KompleksniBroj(i1.Real + i2.Real, i1.Imagine + i2.Imagine);
		return x;
	}

	public static KompleksniBroj operator -(KompleksniBroj i1, KompleksniBroj i2) 
	{
		KompleksniBroj x = new KompleksniBroj(i1.Real - i2.Real, i1.Imagine - i2.Imagine);
		return x;
	}

	public static bool operator ==(KompleksniBroj i1, KompleksniBroj i2) 
	{
		return ((i1.Real * i1.Real + i1.Imagine * i1.Imagine) == (i2.Real * i2.Real + i2.Imagine * i2.Imagine)	? true : false);
	}

	public static bool operator !=(KompleksniBroj i1, KompleksniBroj i2) 
	{
		return ((i1.Real * i1.Real + i1.Imagine * i1.Imagine) != (i2.Real * i2.Real + i2.Imagine * i2.Imagine)	? true : false);
	}

	public static bool operator <(KompleksniBroj i1, KompleksniBroj i2) 
	{
		return ((i1.Real * i1.Real + i1.Imagine * i1.Imagine) <	(i2.Real * i2.Real + i2.Imagine * i2.Imagine)  ? true : false);
	}

	public static bool operator >(KompleksniBroj i1, KompleksniBroj i2) 
	{
		return ((i1.Real * i1.Real + i1.Imagine * i1.Imagine) >	(i2.Real * i2.Real + i2.Imagine * i2.Imagine)  ? true : false);
	}

	public static KompleksniBroj operator ++(KompleksniBroj x) 
	{
		return (new KompleksniBroj(x.Real+1, x.Imagine+1));
	}

	public static KompleksniBroj operator --(KompleksniBroj x) 
	{
		return (new KompleksniBroj(x.Real-1, x.Imagine-1));
	}

	public override string ToString()
	{
		return Real.ToString() + " + " + Imagine.ToString() + "i";
	}
}

public class Test 
{
	public static void Main() 
	{
		KompleksniBroj KB1 = new KompleksniBroj(30, 40);
		KompleksniBroj KB2 = new KompleksniBroj(10, 25);
		KompleksniBroj KB3 = KB1 + KB2;


		Console.WriteLine(KB3);
		KB3++;
		Console.WriteLine(KB3);
		Console.WriteLine(KB1 - KB2);		
		Console.WriteLine(KB1 == KB2);
	}
}
