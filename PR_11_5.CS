using System;
using System.Reflection;
using System.Collections;

public class Test
{
	public static void Main()
	{
		Type t = Type.GetType("System.Collections.ArrayList");
		Object o = Activator.CreateInstance(t);

		t.InvokeMember("Add", System.Reflection.BindingFlags.InvokeMethod, null, o, new object[] {"hello"});
		t.InvokeMember("Add", System.Reflection.BindingFlags.InvokeMethod, null, o, new object[] {"world"});

		ArrayList a = (ArrayList)o;
		foreach(string s in a)
			Console.WriteLine(s);
	}
}
