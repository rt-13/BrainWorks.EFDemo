using System.Collections.Generic;

namespace BrainWorks.EFDemo
{
	public class Product
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int Price { get; set; }

		public IList<Order> Order { get; set; }
	}
}
