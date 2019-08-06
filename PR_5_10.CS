using System;

interface IListBox
{
	int SelectedItem {get; set;}
	void Sort();
}

interface ITextBox
{
	string Tekst {get; set;}
	void SelectTekst();
}

interface IComboBox : IListBox, ITextBox
{
	void Search();
}

class ComboXP : IComboBox
{
	int selectedItem;
	string tekst;

	public ComboXP(int item, string tx)
	{
		selectedItem = item;
		tekst = tx;
	}

	public int SelectedItem
	{
		get { return selectedItem; }
		set { selectedItem = value; }
	}

	public string Tekst
	{
		get { return tekst; }
		set { tekst = value; }
	}

	public void Sort() 
	{	
		Console.WriteLine("Implementirana metoda Sort");
	}

	public void Search() 
	{
		Console.WriteLine("Implementirana metoda Search");
	}

	public void SelectTekst() 
	{
		Console.WriteLine("Implementirana metoda SelectTekst");
	}
}

class Test
{
	static void Main() 
	{
		ComboXP Standard = new ComboXP(0, "");
		Standard.Sort();
	}
}
