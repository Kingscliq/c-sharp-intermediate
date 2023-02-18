using System;
namespace Intermediate.Classes
{
	public class Text : PresentationObject
	{
		public int FontSize { get; set; }
		public int FontFamily { get; set; }

		public void AddHyperLink(string url)
		{
			Console.WriteLine("HyperLink was Added");
		}

	}
}

