using System;

class Test
{
	static void Main() 
	{
		Type t1 = typeof(int);
		Type t2 = typeof(System.Int32);
		Type t3 = typeof(string);

		Console.WriteLine(t1.FullName);
		Console.WriteLine(t2.FullName);
		Console.WriteLine(t3.FullName);
		Console.WriteLine(t2.IsValueType);
		Console.WriteLine(t3.IsValueType);
				
	}
}
