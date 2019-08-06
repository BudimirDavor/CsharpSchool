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

		try 
		{
			Conn.Open();
			OleDbCommand Command = new OleDbCommand("SELECT * FROM PoznatiBrodovi", Conn);
			OleDbDataReader Reader = Command.ExecuteReader();

			while(Reader.Read())
				if((bool)Reader["NaDnuMora"])
					Console.WriteLine(Reader["Naziv"] + " - " + Reader["Drzava"]);
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
	}
}
