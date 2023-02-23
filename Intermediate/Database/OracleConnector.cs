using System;
namespace Intermediate.Database
{
	public class OracleConnector: DbConnector
	{

        public OracleConnector(string connectionString) : base(connectionString)
        {

        }

        public override void OpenConnection()
        {
          if(!String.IsNullOrWhiteSpace(this._connectionString))
                Console.WriteLine("Oracle Database Connected...");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Database Closed...");
        }
    }
}

