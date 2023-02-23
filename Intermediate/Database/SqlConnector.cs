using System;
namespace Intermediate.Database
{
	public class SqlConnector : DbConnector
	{
        public SqlConnector(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
                Console.WriteLine("SQL Database Connection Closed");
        }

        public override void OpenConnection()
        {
            if(!String.IsNullOrWhiteSpace(this._connectionString))
                Console.WriteLine("SQL DbConnction Opened");
            
        }
    }
}

