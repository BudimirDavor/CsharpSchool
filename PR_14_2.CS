using System;

class Test
{
	unsafe static void Main()
	{
		double *p = stackalloc double [100];
		for(int i=0;i<100;i++)
			*p++ = i+1;
		p -= 100;

		PromijeniNiz(p);

		for(int i=0;i<100;i++)
			Console.WriteLine(*(p+i));
	}

	unsafe public static void PromijeniNiz(double *p)
	{
		for(int i=0;i<100;i++)
			*p++ *= 2;
	}
}
