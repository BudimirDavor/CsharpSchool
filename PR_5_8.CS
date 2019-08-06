using System;

class Office
{
	public void PokreniProgram()
	{
		Console.WriteLine("Office je pokrenut");
	}

	public virtual void SpremiDatoteku()		
	{
		Console.WriteLine("Spremi Office datoteku");
	}

	public void ZatvoriProgram()
	{	
		Console.WriteLine("Office je zatvoren");
	}
}

class Word: Office
{
	public override void SpremiDatoteku()
	{
		Console.WriteLine("Spremi doc datoteku");
	}
}

class Excel: Office
{
	public override void SpremiDatoteku()
	{
		Console.WriteLine("Spremi xls datoteku");
	}
}

class Access: Office
{
}


class Test
{
	static void Main() 
	{
		Office[] Documents = new Office[3];
		Documents[0] = new Word();
		Documents[1] = new Excel();
		Documents[2] = new Access();
		for(int i=0;i<3;i++)
			Documents[i].SpremiDatoteku();
	}
}
