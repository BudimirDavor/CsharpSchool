using System;

public class Test
{                  
	public static void Main() 
	{
		#if(NAPON && STRUJA)
			Console.WriteLine("Otpor se može izraèunati");
		#elif(NAPON && !STRUJA)
			Console.WriteLine("Otpor se ne može izraèunati");
		#elif(!NAPON && STRUJA)
			Console.WriteLine("Otpor se ne može izraèunati");
		#elif(!NAPON && !STRUJA)
			Console.WriteLine("Otpor se ne može izraèunati");
		#endif
	}
}
