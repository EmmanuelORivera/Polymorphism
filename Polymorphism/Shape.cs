﻿namespace Polymorphism
{
	public class Shape
	{
		public int Width { get; set; }
		public int Height { get; set; }

		public virtual void Draw()
		{
            Console.WriteLine("Draw a shape");
        }
	}
}