using System;

namespace BlipBlop
{
	public class BlipBlop
	{
		static void Main(string[] args)
		{
			for(int i=1;i<=100;i++)
			{
				var text = TextToPrint(i);
				Console.WriteLine(text);
			}
			Console.ReadLine();
		}
		public static string TextToPrint(int value)
		{
			if ((value % 5 == 0) && (value % 3 == 0))
			{
				return "BlipBlop";
			}
			else if (value % 3 == 0)
			{
				return "Blip";
			}
			else if (value % 5 == 0)
			{
				return "Blop";
			}
			else
				return value.ToString();
		}

	}
}
