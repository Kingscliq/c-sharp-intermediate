using System;
namespace Intermediate.Database
{
	public abstract class DbConnector
	{
		protected string _connectionString { get; set; }
		public readonly TimeSpan _timeSpan;

		public DbConnector(String connectionString)
		{
			_connectionString = connectionString;
		}

        public DbConnector(String connectionString, TimeSpan timeSpan)
			:this(connectionString)
        {
			this._timeSpan = timeSpan;
        }

        public abstract void CloseConnection();
		public abstract void OpenConnection();
	}
}

