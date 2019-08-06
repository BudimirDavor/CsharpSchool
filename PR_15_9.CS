using System;
using System.Data.OleDb;

class Test
{	
	static void Main()
	{
		string Database = "Brodovi.mdb";
		OleDbConnection Conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" +	
					Database + ";Persist Security Info=False");

		string Sailboat1 = "Black Magic";
		string Sailboat2 = "Alinghi";

		try 
		{
			Conn.Open();
			string sSQL = "UPDATE PoznatiBrodovi SET " + "NaDnuMora = ?" + " WHERE Naziv = ?";
		
			OleDbCommand Command = new OleDbCommand(sSQL, Conn);
			
			Command.Parameters.Add("NaDnuMora", OleDbType.Boolean);
			Command.Parameters.Add("Naziv", OleDbType.Char);
			Command.Parameters["NaDnuMora"].Value = true;
			Command.Parameters["Naziv"].Value = Sailboat1;
			Command.ExecuteNonQuery();
			
			Command.Parameters.Add("NaDnuMora", OleDbType.Boolean);
			Command.Parameters.Add("Naziv", OleDbType.Char);
			Command.Parameters["NaDnuMora"].Value = true;
			Command.Parameters["Naziv"].Value = Sailboat2;
			Command.ExecuteNonQuery();
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

