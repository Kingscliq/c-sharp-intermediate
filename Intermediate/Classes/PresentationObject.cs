using System;
namespace Intermediate.Classes
{
	public class PresentationObject
	{

		public int Width { get; set; }
		public int Height { get; set; }


		public void Copy()
		{
			Console.WriteLine("Object was with height {0} and width {1} was coppied to clipboard", this.Height, this.Width);
		}

        public void Duplicate()
        {
			Console.WriteLine("Object was duplicated");
        }


    }
}

