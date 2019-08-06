using System;

class Test
{
	static void Main()
	{
		object[] Arr = new object[] {2001, " Oddisey", 9.5, " weeks"};

		foreach(object o in Arr)
		{
			Console.Write(o);
			if(o.GetType() == typeof(string))
				Console.WriteLine();
		}
	}
}
