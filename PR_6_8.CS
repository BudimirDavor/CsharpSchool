using System;

public class Test
{
	public static double UseParams(params double[] Otpori) 
	{
		if(Otpori.Length == 0)
			return 0;
		else if(Otpori.Length == 1)
			return Otpori[0];

		double UkupniOtpor = Otpori[0] * Otpori[1] / (Otpori[0] + Otpori[1]);	
		for (int i = 2; i < Otpori.Length; i++ )
			UkupniOtpor = UkupniOtpor * Otpori[i] / (UkupniOtpor + Otpori[i]);
		return UkupniOtpor;
	}

	public static void Main() 
	{
		double R = UseParams(10);
		Console.WriteLine("{0} Ohm", R); 

		R = UseParams(10, 10);
		Console.WriteLine("{0} Ohm", R); 
		
		R = UseParams(10, 20, 30, 40, 50, 60, 70, 80, 90, 100);
		Console.WriteLine("{0} Ohm", R); 
	}
}
