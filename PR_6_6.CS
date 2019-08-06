using System;
using System.Text;

class Test
{
	public static void Promijeni1(StringBuilder sb)
	{
		sb = new StringBuilder("Linux");
		return;
	}

	public static void Promijeni2(ref StringBuilder sb)
	{
		sb = new StringBuilder("Linux");
		return;
	}

	static void Main() 
	{
		StringBuilder s1 = new StringBuilder("Windows");
		Promijeni1(s1);
		Console.WriteLine(s1);

		StringBuilder s2 = new StringBuilder("Windows ");
		Promijeni2(ref s2);
		Console.WriteLine(s2);
	}
}
