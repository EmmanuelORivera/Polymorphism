namespace Polymorphism
{
	public abstract class Shape
	{

		// Rules
		// 1. Abstact member can not include implementation.
		// 2. If a member is declared as abstract, the containing class needs to be declared as abstract too.
		// 3. Derived class must implement all abstract members in the base abstract class.
		// 4. Abstract class can not be instantiated.
		public int Width { get; set; }
		public int Height { get; set; }

		public abstract void Draw();
	}
}