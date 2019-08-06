using System;
using System.IO;

class Test
{
	private const string Big = "bignumber.txt";
		
	static void Main()
	{
		StreamWriter FWrite = null;
		try
		{
			FWrite = new StreamWriter(Big, false, System.Text.Encoding.ASCII);

			FWrite.WriteLine("milijun");
			int i = 1000000;
			FWrite.WriteLine(i);

			FWrite.WriteLine("milijarda");
			i = 1000000000;
			FWrite.WriteLine(i);
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

		StreamReader FRead = null;
		try
		{
			FRead = new StreamReader(Big,
			System.Text.Encoding.ASCII);
			string s;
			while((s = FRead.ReadLine()) != null)
				Console.WriteLine(s);
			
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

		FileInfo f = new FileInfo(Big);
		Console.WriteLine(f.Length + " bytes");
	}
}
