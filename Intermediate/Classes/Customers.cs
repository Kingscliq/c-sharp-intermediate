using System;
namespace Intermediate.Classes
{
	public class Customers
	{
		public int Id { get; set;}
		public string? Name { get; set; }

		public void GetCustomerRating()
		{
		   var rating = this.CalculateRating();

		   if(rating == 0)
			{
				Console.WriteLine("Customer Should not be promoted");
			}
			else
			{
				Console.WriteLine("Customers Should be Promoted");
			}
		}

		public int CalculateRating()
		{
			return 0;
		}
	}
}

