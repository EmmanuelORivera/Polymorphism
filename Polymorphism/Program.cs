using System;

namespace Polymorphism
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UseDrawShapes();
		}
		static void UseDrawShapes()
		{
			var shapes = new List<Shape>();
			shapes.Add(new Circle());
			shapes.Add(new Rectangle());
			shapes.Add(new Triangle());

			var canvas = new Canvas();
			canvas.DrawShapes(shapes);
		}
	}
}