using System;
using System.Data;
using System.Data.OleDb;

class Test
{	
	static void Main()
	{
		string Database = "Brodovi.mdb";

		OleDbDataAdapter Adapter = new OleDbDataAdapter("SELECT * FROM PoznatiBrodovi",
			"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" +
			Database + ";Persist Security Info=False");

		OleDbCommandBuilder Builder = new OleDbCommandBuilder(Adapter);

		DataSet ds = new DataSet();
		Adapter.Fill(ds, "PoznatiBrodovi");
		DataTable table = ds.Tables["PoznatiBrodovi"];

		foreach(DataRow row in table.Rows)
			row["NaDnuMora"] = !(bool)row["NaDnuMora"];

		Adapter.Update(ds, "PoznatiBrodovi");
		ds.AcceptChanges();
	}
}
