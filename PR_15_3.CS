using System;
using System.Xml;
using System.Diagnostics;

class Test
{
	static void Main()
	{
		string Url = "http://newsrss.bbc.co.uk/rss/newsonline_uk_edition/technology/rss.xml";
		XmlDocument Doc = new XmlDocument();
		Doc.Load(Url);
		XmlNodeList Nodes = Doc.GetElementsByTagName("item");
		
		int i = 0;
		foreach(XmlNode Node in Nodes)
		{
			Console.WriteLine("{0}\n{1}\n{2}\n\n", Node["title"].InnerText, Node["link"].InnerText,	Node["pubDate"].InnerText);
			if(i == 0  ||  i == 1  ||  i == Nodes.Count - 2  ||   i == Nodes.Count - 1)
			{
				Process IE = new Process();
				IE.StartInfo.FileName = "iexplore.exe";
				IE.StartInfo.Arguments = Node["link"].InnerText;  				
				IE.Start();
			}
			i++;
		}
	}
}
