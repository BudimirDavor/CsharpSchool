using System;
using System.Collections;
using System.Xml;

class XMLTLista
{
	string[,] Arr = new  string[,] 
	{
		{"Australija", "Japan", "Velika Britanija", "USA", "EU"}, 
		{"AUD", "YPY", "GBP", "USD", "EUR"},
		{"036", "392", "826", "840", "978"},
		{"1", "100", "1", "1", "1"},
		{"4.385692", "4.704524", "10.960638", "5.570351", "7.357876"}
	};
	
	public void CreateXMLFile()
	{
		XmlTextWriter Writer = null;

		try 
		{
			Writer = new XmlTextWriter("TL.xml", System.Text.Encoding.Default);
			Writer.Formatting = Formatting.Indented;

			Writer.WriteStartDocument();
			Writer.WriteStartElement("TecajnaLista");

			for(int i=0;i<Arr.GetLength(1);i++)
			{
				Writer.WriteStartElement("Valuta");

				Writer.WriteElementString("Drzava", Arr[0, i]);
				Writer.WriteElementString("Oznaka", Arr[1, i]);
				Writer.WriteElementString("Sfr", Arr[2, i]);
				Writer.WriteElementString("Jedinica", Arr[3, i]);
				Writer.WriteElementString("Iznos", Arr[4, i]);
				
				Writer.WriteEndElement();
			}
			Writer.WriteEndElement();
		}
		catch(Exception e)
		{
			Console.WriteLine(e.Message);
		}
		finally 
		{
			if(Writer != null)
				Writer.Close();
		}
	}
}

class Test
{
	static void Main()
	{
		XMLTLista XmlDynamic = new XMLTLista();
		XmlDynamic.CreateXMLFile();
	}
}
