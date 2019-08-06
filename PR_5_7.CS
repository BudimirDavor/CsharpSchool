using System;

class Bazna
{
	private int xCoord = 100;
	protected int yCoord = 200;

	public Bazna()
	{
		Console.Write("Bazni konstruktor, ");
		Console.WriteLine("x = {0}, y = {1}", xCoord, yCoord);
	}

	public int XCoord
	{
		get 
		{ 
			return xCoord; 
		}
	}

	public void BaseMethod()
	{
		Console.WriteLine("Bazna metoda pozvana od {0}", GetType());
	}
}

class Izvedena : Bazna
{
	private int zCoord = 300;

	public Izvedena()
	{
		Console.Write("Izvedeni konstruktor, ");
		Console.WriteLine("x = {0}, y = {1}, z = {2}", XCoord, yCoord, zCoord);
	}
}

class Test
{
	static void Main() 
	{
		Bazna Base = new Bazna();
		Izvedena Derived = new Izvedena();
		Base.BaseMethod();
		Derived.BaseMethod();
	}
}
