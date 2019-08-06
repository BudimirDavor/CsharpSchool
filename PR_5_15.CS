using System;

class Vanjska
{
	private int x = 100;

	private class Unutarnja
	{
		public void fIn() 
		{
			Vanjska v = new Vanjska();
			Console.WriteLine(v.x);
		}
	}

	public void fOut()
	{
		Unutarnja u = new Unutarnja();
		u.fIn();
	}
}

class Test
{
	static void Main() 
	{
		Vanjska v = new Vanjska();
		v.fOut();
	}
}
