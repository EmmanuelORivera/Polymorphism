namespace Polymorphism
{
	public class SqlConnection : DbConnection
	{
		public SqlConnection(string connectionString) : base(connectionString)
		{
		}

		public override void Close()
		{
			Console.WriteLine("Close SqlConnection");
		}

		public override void Open()
		{
			Console.WriteLine("Open SqlConnection");
		}
	}
}