using System;
namespace Intermediate.Classes
{
	public class GoldCustomer: Customers
	{ 
		public void OfferVoucher(){
			this.GetCustomerRating();

			this.CalculateRating();
			Console.WriteLine("Voucher has been offered");
		}


	}
}

