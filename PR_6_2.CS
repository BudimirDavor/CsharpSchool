using System;

class MobileDevice
{
	private string opSustav;
	private float marketShare;
	
	public MobileDevice(string os)
	{	
		opSustav = os;	
	}

	public float MarketShare
	{
		get	{return marketShare;}
		set	{marketShare = value;}
	}

	public string OPSustav
	{
		get	{return opSustav;}
		set	{opSustav = value;}
	}

}

class Test
{
	public static MobileDevice[] SetMarketShare(MobileDevice[] Arr)
	{
		Arr[0].MarketShare = 45;
		Arr[1].MarketShare = 35;
		Arr[2].MarketShare = 20;

		return Arr;
	}

	static void Main() 
	{
		MobileDevice[] Gadgets = new MobileDevice[3];
		Gadgets[0] = new MobileDevice("Palm OS");
		Gadgets[1] = new MobileDevice("Pocket PC");
		Gadgets[2] = new MobileDevice("Symbian");

		SetMarketShare(Gadgets);
		
		for(int i = 0;i<3;i++)
			Console.WriteLine(Gadgets[i].OPSustav + " - " +	Gadgets[i].MarketShare + " %");
}
}
