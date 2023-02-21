using System;
namespace Intermediate.Classes
{
	public class Shape
	{
		public int Height { get; set; }
		public int Width { get; set; }
		public int Position { get; set; }


		public virtual void Draw()
		{
			Console.WriteLine("Draw a shape, depending on the method thats passed in");
		}
	}

	public class Cirlce : Shape
	{

        public override void Draw()
        {
			//Implement a Method to Override the draw methid in the parent class
			Console.WriteLine("Draw a Circle");
		}
	}

    public class Rectangle: Shape
    {
        public override void Draw()
        {
            //Implement a Method to Override the draw methid in the parent class
            Console.WriteLine("Draw a Rectangle");
        }
    }


}

