using System;

abstract class Office
{
	abstract public void SpremiDatoteku();

}

class Excel: Office
{
	public override void SpremiDatoteku()
	{
		Console.WriteLine("Spremi xls datoteku");
	}
}

class Test
{
	static void Main() 
	{		
		Excel Exc = new Excel();
		Exc.SpremiDatoteku();	
	}
}
