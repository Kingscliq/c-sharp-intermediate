using System;
namespace Intermediate.Database
{
	public abstract class DbConnector
	{
		private  string _connectionString { get; set; }
		private readonly TimeSpan _timeSpan;

		public DbConnector(String connectionString)
		{
			_connectionString = connectionString;
		}

		public abstract void CloseConnection();
		public abstract void OpenConnection();
	}
}

