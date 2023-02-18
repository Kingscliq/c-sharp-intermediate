using System;
namespace Intermediate.Classes
{
	public class Logger
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
		}

        public static implicit operator Logger(string v)
        {
            throw new NotImplementedException();
        }
    }
}

