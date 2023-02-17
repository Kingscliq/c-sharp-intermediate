using System;
namespace Intermediate.Classes
{
	public class Customer
	{

        public String Name = "Ezenwa";
        public int Id;

		public Customer()
		{
            //calling a constructor without an initialization
		}
        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}

