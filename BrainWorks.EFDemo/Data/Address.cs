namespace BrainWorks.EFDemo
{
	public class Address
	{
		public int Id { get; set; }

		public string Address1 { get; set; }

		public string Address2 { get; set; }

		public string Landmark { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string PinCode { get; set; }

		public int CustomerId { get; set; }

		public Customer Customer { get; set; }
	}
}
