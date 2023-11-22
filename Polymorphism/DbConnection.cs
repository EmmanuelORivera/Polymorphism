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
}