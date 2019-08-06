using System;
using System.IO;

class Test
{
	private const string Big = "bignumber.bin";
		
	static void Main()
	{
		Stream IzlazniTok = File.OpenWrite(Big);
		BinaryWriter FWrite = null;

		try
		{
			FWrite = new BinaryWriter(IzlazniTok);

			FWrite.Write("milijun");
			int i = 1000000;
			FWrite.Write(i);

			FWrite.Write("milijarda");
			i = 1000000000;
			FWrite.Write(i);
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

		Stream UlazniTok = File.OpenRead(Big);
		BinaryReader FRead = null;

		try
		{
			FRead = new BinaryReader(UlazniTok);

			Console.WriteLine(FRead.ReadString());
			Console.WriteLine(FRead.ReadInt32());
			Console.WriteLine(FRead.ReadString());
			Console.WriteLine(FRead.ReadInt32());
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
