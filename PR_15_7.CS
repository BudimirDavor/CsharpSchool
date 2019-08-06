using System;
using System.Data.OleDb;

class Test
{	
	static void Main()
	{
		string Database = "Brodovi.mdb";
		OleDbConnection Conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" +
				Database + ";Persist Security Info=False");
		string LegendaryShip = "Bismarck";

		try 
		{
			Conn.Open();
			string sSQL = "DELETE FROM PoznatiBrodovi WHERE Naziv = " + "\'" + LegendaryShip + "\'";

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
