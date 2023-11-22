using System;

namespace Polymorphism
{
	public abstract class DbConnection
	{
		protected string ConnectionString { get; set; }
		protected TimeSpan Timeout { get; set; }

		public DbConnection(string connectionString)
		{
			if (string.IsNullOrEmpty(connectionString)) throw new ArgumentException("ConnectionString can't be an empty string or null");
			ConnectionString = connectionString;
		}

		public void SetTimeout(TimeSpan timeout)
		{
			if (timeout < TimeSpan.Zero) throw new ArgumentException("Timeout cannot be negative time span");

			Timeout = timeout;
		}

		public abstract void Open();
		public abstract void Close();
	}

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
	internal class Program
	{
		static void Main(string[] args)
		{
			UseDrawShapes();
			UseDatabaseConnection();
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

		static void UseDatabaseConnection()
		{
			var sqlConnection = new SqlConnection("This is a sql connectionString");
			sqlConnection.Open();
			sqlConnection.Close();
			var oracleConnection = new OracleConnection("This is a oracle connectionString");
			oracleConnection.Open();
			oracleConnection.Close();	
		}
	}
}