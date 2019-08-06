using System;

class Test
{
	static void Main()
	{
		string s = "HAL";
		int i = 0;

		while(i++ < s.Length)
			Console.Write((char)(s[i-1] + 1));
	}
}
