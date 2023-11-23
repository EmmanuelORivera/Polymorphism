namespace Polymorphism
{
	public class DbCommand
	{
		private readonly DbConnection _connection;
		private readonly string _sqlQuery;
		public DbCommand(DbConnection dbConnection, string sqlQuery)
		{
			if (dbConnection == null) throw new ArgumentNullException("dbConnection can't be a null value");
			if (string.IsNullOrEmpty(sqlQuery)) throw new ArgumentException("sqlQuery can't an empty string or a null value");

			_connection = dbConnection;
			_sqlQuery = sqlQuery;
		}

		public void Execute()
		{
			_connection.Open();

            Console.WriteLine("Executing the command: {0}", _sqlQuery);

			_connection.Close();
        }
	}
}