using System;

namespace Polymorphism
{
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

			var sqlDbCommand = new DbCommand(null,"Select * from Clients");
			var oracleDbCommand = new DbCommand(oracleConnection, "Select * from Users");
			sqlDbCommand.Execute();
			oracleDbCommand.Execute();
		}
	}
}