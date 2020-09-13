using System.Collections.Generic;

namespace BrainWorks.EFDemo
{
	public class Customer
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string Mobile { get; set; }

		public IList<Order> Orders { get; set; }

		public IList<Address> Addresses { get; set; }
	}
}
