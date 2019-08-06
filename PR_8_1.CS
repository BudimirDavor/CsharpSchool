using System;

public class Test 
{
	public static void Main() 
	{
		string[] RedniBrojevi1 = new string[] {"First", "Second", "Third", "Fourth", "Fifth"};
		Array.Sort(RedniBrojevi1);

		for(int i=0; i < RedniBrojevi1.Length;i++)
			Console.Write(RedniBrojevi1[i] + "  ");
		Console.WriteLine();

		Array RedniBrojevi2 = Array.CreateInstance(typeof(String), 5);
		RedniBrojevi2.SetValue("First", 0);
		RedniBrojevi2.SetValue("Second", 1);
		RedniBrojevi2.SetValue("Third", 2);
		RedniBrojevi2.SetValue("Fourth", 3);
		RedniBrojevi2.SetValue("Fifth", 4);
		Array.Reverse(RedniBrojevi2);
		
		for(int i=0; i < RedniBrojevi2.Length;i++)
			Console.Write(RedniBrojevi2.GetValue(i) + "  ");
	}
}
