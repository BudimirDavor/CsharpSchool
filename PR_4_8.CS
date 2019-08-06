using System;

class Test
{
	static void Main()
	{		
		string s = "HyperTextMarkupLanguage";
		for(int i = 0;i < s.Length && s[i] != 'M'; i++)
			Console.Write(s[i]);
	}
}
