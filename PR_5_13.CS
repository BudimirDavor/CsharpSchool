using System;
// . . . 
// . . . 
public static void Main()
{		
	const int Num = 10000000;
	DateTime start = DateTime.Now;

	SKoordinate[] s = new SKoordinate[Num];
	for(int i = 0;i<Num;i++)
		s[i] = new SKoordinate(i, i);
		
	DateTime end1 = DateTime.Now;
	TimeSpan Int1 = end1 - start;
	Console.WriteLine("Strukture kreirane za " + Int1.Seconds + "." 
						+ Int1.Milliseconds + " sec");
	CKoordinate[] c = new CKoordinate[Num];
	for(int i = 0;i<Num;i++)
		c[i] = new CKoordinate(i, i);
		
	DateTime end2 = DateTime.Now;
	TimeSpan Int2 = end2 - end1;
	Console.WriteLine("Klase kreirane za " + Int2.Seconds + "." + Int2.Milliseconds + " sec");
}
