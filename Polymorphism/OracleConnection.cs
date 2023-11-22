namespace Polymorphism
{
	public class OracleConnection : DbConnection
	{
		public OracleConnection(string connectionString) : base(connectionString)
		{
		}

		public override void Close()
		{
			Console.WriteLine("Close OracleConnection");
		}

		public override void Open()
		{
			Console.WriteLine("Open OracleConnection");
		}
	}
}