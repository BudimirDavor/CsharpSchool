using System;

class EnglishToCroatian
{
	private string [] English = new string [100];
	private string [] Hrvatski = new string [100];
	
	public EnglishToCroatian(string [] English, string [] Hrvatski)
	{
		int i = 0;
		foreach(string s in English)
			this.English[i++] = s;

		i = 0;
		foreach(string s in Hrvatski)
			this.Hrvatski[i++] = s;
	}

	public string this[string str]
	{
		get 
		{
			int i = 0;	
			foreach(string s in English)
				if(s == str)
					return(Hrvatski[i]);
				else
					i++;

			return "rijeè nije pronaðena";
		}
	}
}

public class Test 
{
	public static void Main() 
	{
		string[] str1 = new string[] {"capacity", "current", "inductance", "resistance", "voltage",};
		string[] str2 = new string[] {"kapacitet", "struja", "induktivitet", "otpor", "napon"};

		EnglishToCroatian Dict = new EnglishToCroatian(str1, str2);
		Console.WriteLine("voltage" + " - " + Dict["voltage"]);
	}
}
