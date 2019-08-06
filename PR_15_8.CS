using System;
using System.Data.OleDb;

class Test
{	
	static void Main()
	{
		string Database = "Brodovi.mdb";
		OleDbConnection Conn = new OleDbConnection
		("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" +
			Database + ";Persist Security Info=False");
		
		int ID = 100;
		string Name = "Rimska Galija";
		string Drzava = "Rimsko Carstvo";
		double Duzina = 25;
		DateTime DatumPorinuca = new DateTime(200, 1, 1);
		bool NaDnuMora = true;

		string sSQL = "INSERT INTO PoznatiBrodovi VALUES(" +
			"\'" + ID + "\'" + ", " +
			
			"\'" + Name + "\'" + ", " +
			
			"\'" + Drzava + "\'" + ", " +
			
			"\'" + Duzina + "\'" + ", " +

			"\'" + DatumPorinuca.Day + "." + 
			DatumPorinuca.Month + "." + 
			DatumPorinuca.Year + "\'" + ", " +

			"\'" + (NaDnuMora == false ?  "0" : "1") + "\'" + ")";

		try 
		{
			Conn.Open();
			OleDbCommand Command = new OleDbCommand(sSQL, Conn);
			Command.ExecuteNonQuery();			
		}
		catch(OleDbException e) 
		{
			Console.WriteLine(e.Message);
		}
		finally 
		{
			Conn.Close ();
		}
	}
}
