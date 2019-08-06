using System;
using System.Reflection;

public class Test
{
	public static void Main()
	{	
		Assembly Skup = Assembly.Load("Test");
		Type[] Tipovi = Skup.GetTypes();
		
		foreach(Type t in Tipovi)
		{
			Console.WriteLine(t.Name);
			ConstructorInfo[] Arr = t.GetConstructors();
			
			foreach(ConstructorInfo ci in Arr)
				Console.WriteLine(ci);
		}
	}
}
