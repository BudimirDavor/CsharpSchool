using System;

namespace Westinghouse
{
	class Generator
	{
		private float PowerMW;

		public Generator(float f)
		{
			PowerMW = f;
		}
	}
}

namespace Koncar
{
	class Generator
	{
		private float SnagaMW;

		public Generator(float f)
		{
			SnagaMW = f;
		}
	}
}

class Test
{
	static void Main() 
	{
		Westinghouse.Generator w = new Westinghouse.Generator(100);
		Koncar.Generator s = new Koncar.Generator(120);
	}
}
