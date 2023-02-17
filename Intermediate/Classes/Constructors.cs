using System;
namespace Intermediate.Classes
{
	public class Customer
	{

        public String Name = "Ezenwa";
        public int Id;
        public List<Orders> Orders;

		public Customer()
		{
            //calling a constructor without an initialization
            this.Orders = new List<Orders>(); 
           
		}
        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(string name, int id)
            :this(id)
        {
            this.Name = name;
        }
    }
}

