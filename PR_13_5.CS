using System;
using System.IO;

class Test
{
	private const string Big = "bignumber.bin";
		
	static void Main()
	{
		double [] Constants = new double[] {1.60217653, 3.1415926,
		2.718, 9.80665, 6.6742};
		Stream IzlazniTok = File.OpenWrite(Big);
		BinaryWriter FWrite = null;

		try
		{
			FWrite = new BinaryWriter(IzlazniTok);
			foreach(double d in Constants)
				FWrite.Write(d);
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
			while(UlazniTok.Position < UlazniTok.Length)
				Console.WriteLine(FRead.ReadDouble());
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
