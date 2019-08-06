using System;

interface IComboXP
{
	void Sort();
}

interface IComboVista
{
	void SortAdvanced();
}

class ComboXP : IComboXP
{
	public void Sort() 
	{	
		Console.WriteLine("Sortirano");
	}
}

class ComboVista : ComboXP, IComboVista
{
	public void SortAdvanced()
	{
		Console.WriteLine("Napredno sortirano");
	}
}

class Test
{
	static void Main() 
	{
		ComboXP [] Arr = new ComboXP[4];
		Arr[0] = new ComboXP();	
		Arr[1] = new ComboXP();	
		Arr[2] = new ComboVista();
		Arr[3] = new ComboVista();

		foreach(ComboXP com in Arr)
		{
			if(com is IComboVista)
			{
				IComboVista Icv = (IComboVista) com;
				Icv.SortAdvanced();
			}
			else if(com is IComboXP)
			{
				IComboXP Ixp = (IComboXP) com;
				Ixp.Sort();
			}
		}

	}
}
