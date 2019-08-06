using System;

class Test
{
	public static double KompleksnaVrijednost(double real, double im)
	{
		double d = Math.Sqrt(real * real + im * im);
		return d;
	}

	static void Main() 
	{
		double Real = 6.7, Imagine = 5.3;
		double Absolute = KompleksnaVrijednost(Real, Imagine);
		Console.WriteLine(Absolute);
	}
}
