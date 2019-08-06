using System;

class ComboBox
{
	private string [] stavke = new string [100];
	
	public ComboBox(string [] stavke)
	{
		int i = 0;
		foreach(string s in stavke)
			this.stavke[i++] = s;
	}

	public string this[int ind]
	{
		get 
		{
			return (ind >= 0 || ind <= 100) ?  stavke[ind] : null;
		}

		set 
		{
			if(ind >= 0 || ind <= 100)
				stavke[ind] = value;
		}
	}
}

public class Test 
{
	public static void Main() 
	{
		string[] str = new string[] {"First", "Second", "Third", "Fourth", "Fifth"};
		ComboBox cb = new ComboBox(str);
		Console.WriteLine(cb[4]);
		cb[4] = "Peti";
		Console.WriteLine(cb[4]);
	}
}
