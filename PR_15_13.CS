using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Data.OleDb;

class DoIFeelLucky
{
	private string FileToSave = "About";
	
	public DoIFeelLucky()
	{
	}

	public string FindShip(int ind)
	{
		string Database = "Brodovi.mdb";
		OleDbConnection Conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" +
			Database + ";Persist Security Info=False");
		
		try 
		{
			Conn.Open();
			OleDbCommand Command = new OleDbCommand("SELECT * FROM PoznatiBrodovi", Conn);
			OleDbDataReader Reader = Command.ExecuteReader();
			
			int i = 0;
			while(Reader.Read())
				if(i++ == ind)
				{
					string s = (string)Reader["Naziv"];
					Reader.Close();
					FileToSave += s;
					FileToSave += ".txt";
					return s;
				}
			Reader.Close();
		}
		catch(OleDbException e) 
		{
			Console.WriteLine(e.Message);
		}
		finally 
		{
			Conn.Close();
		}
		return null;
	}

	public void CallGoogleSearch(string toSearch)
	{
		GoogleSearchService Search = null;
		GoogleSearchResult Results = null;

		try 
		{
			Search = new GoogleSearchService();
			Results = Search.doGoogleSearch(
				"Vaš Licence Key", 
				toSearch, 0, 10, false, "", false, "", "", "");
		}
		catch(System.Net.WebException e) 
		{
			Console.WriteLine(e.Message);
			return;
		}

		Process IE = new Process();
		IE.StartInfo.FileName = "iexplore.exe";
		IE.StartInfo.Arguments = Results.resultElements[0].URL;
		IE.Start();

		SaveToDisk(Results);
	}

	public void SaveToDisk(GoogleSearchResult Results)
	{
		StreamWriter FWrite = null;
		try
		{
			FWrite = new StreamWriter(FileToSave, false, System.Text.Encoding.ASCII);
			foreach(ResultElement r in Results.resultElements)
			{
				FWrite.WriteLine(r.URL);
				FWrite.WriteLine(r.title);
				FWrite.WriteLine(r.snippet);
				FWrite.WriteLine();
				FWrite.WriteLine();
			}
		}
		catch (Exception e) 
		{
			Console.WriteLine(e.Message);
		}
		finally
		{
			if(FWrite != null)
				FWrite.Close();
		}
	}
}


class Test
{	
	static void Main()
	{
		DoIFeelLucky fl = new DoIFeelLucky();
		Random x = new Random();
		string ShipForSearch = fl.FindShip(x.Next(15));

		ShipForSearch += " + ship";
		fl.CallGoogleSearch(ShipForSearch);	
	}
}
