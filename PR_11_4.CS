using System;
using System.Reflection;

public class Test
{
	public static void Main()
	{
		Type t = Type.GetType("System.Console");
		Type [] ArgArr = new Type[1];
		ArgArr[0] = Type.GetType("System.String");

		MethodInfo Cout = t.GetMethod("WriteLine", ArgArr);
		Object [] Argumenti = new Object[1];
		
		Argumenti[0] = "hello, world";
		Cout.Invoke(t, Argumenti);
	}
}

