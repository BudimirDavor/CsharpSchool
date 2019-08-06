using System;
using System.IO;
using System.Net;
using System.Diagnostics;

class Test
{
	static void Main()
	{
		string Url = "http://www.eurosport.com";
		string HTMLSource = null;
		StreamReader Reader = null;

		try 
		{
			WebRequest WebZahtjev = WebRequest.Create(Url);
			WebResponse WebOdgovor = WebZahtjev.GetResponse();
			Reader = new StreamReader(WebOdgovor.GetResponseStream());
			HTMLSource = Reader.ReadToEnd();
		}
		catch(System.Net.WebException e) 
		{
			Console.WriteLine("Ne mogu se spojiti na www.eurosport.com");
			return;
		}
		finally 
		{
			if(Reader != null)
				Reader.Close ();
		}

		StreamWriter FWrite = null;
		try
		{
			string CurrFolder = Directory.GetCurrentDirectory();
			FWrite = new StreamWriter(CurrFolder + "\\eurosport.html", false,
				System.Text.Encoding.ASCII);
			FWrite.Write(HTMLSource);
			
			Process IE = new Process();
			IE.StartInfo.FileName = "iexplore.exe";
			IE.StartInfo.Arguments = CurrFolder + "\\eurosport.html";
			IE.Start();
		}
		catch(Exception e) 
		{
			Console.WriteLine("Ne mogu zapisati u datoteku");
		}
		finally
		{
			if(FWrite != null)
				FWrite.Close();
		}
	}
}
