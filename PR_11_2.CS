using System;
using System.Runtime.InteropServices; 

class Test
{
	[DllImportAttribute("user32.dll")]
	public static extern int MessageBoxA(int i, string s1, string s2, int t);

	public static int Main() 
	{
		return MessageBoxA(0, "API is called", "Win32", 0);
	}
}
