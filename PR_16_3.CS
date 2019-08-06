using System;
using System.Collections.Generic;

public class MyClass
{
	private string element = "";

	public MyClass(string s)
	{
		element = s;
	}

	public string Element
	{
		get {return element;}
		set {element = value;}
	}

}

class Test
{
	static void Main()
	{
		List<MyClass> Arr = new List<MyClass>();
		Arr.Add(new MyClass("Gold"));
		Arr.Add(new MyClass("Silver"));
		Arr.Add(new MyClass("Bronze"));

		foreach(MyClass x in Arr)
			Console.WriteLine(x.Element);
	}
}
