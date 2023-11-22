using System;

namespace Polymorphism
{
	public class Circle : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Draw a circle");
		}
	}
	public class Rectangle : Shape {
		public override void Draw()
		{
			Console.WriteLine("Draw a rectangle");
		}
	}
	public class Triangle : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Draw a triangle");
		}
	}
	public class Canvas
	{
		public void DrawShapes(List<Shape> shapes)
		{
			foreach (var shape in shapes)
			{
				shape.Draw();
			}
		}
	}
	public class Shape
	{
		public int Width { get; set; }
		public int Height { get; set; }

		public virtual void Draw()
		{
            Console.WriteLine("Draw a shape");
        }
	}
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