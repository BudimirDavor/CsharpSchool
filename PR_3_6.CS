using System;

public class Test 
{
	public static void Main() 
	{
		int Flag = 0;
		bool Uvjet = false;	
		if(Uvjet  &&  VeryImportant())	
			Flag = 1;
	}

	public static bool VeryImportant()
	{
		int x = 0;
		// Obavljanje vrlo važnog posla ...
		return x == 0 ? true : false;
	}
}
