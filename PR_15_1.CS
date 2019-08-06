using System;
using System.Xml;

class Test
{
	static void Main()
	{
		XmlDocument Doc = new XmlDocument();

		try
		{
			Doc.Load("TecajnaLista.xml");
		}
		catch(XmlException e)
		{
			Console.WriteLine("Dokument nije dobro oblikovan");
		}
		catch(System.IO.IOException e)
		{
			Console.WriteLine("Ne postoji datoteka TecajnaLista.xml");
		}

		XmlNodeList Nodes = Doc.GetElementsByTagName("Valuta");

		foreach(XmlNode Node in Nodes)
			Console.WriteLine("{0} {1} = {2} kn", Node["Jedinica"].InnerText, Node["Oznaka"].InnerText, Node["Iznos"].InnerText);
	}
}
