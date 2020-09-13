using System;
using System.Collections.Generic;
using System.Linq;

namespace BrainWorks.EFDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			DataContext context = new DataContext();
			Customer updateCustomer = context.Customers.First(x => x.Id == 3);
			updateCustomer.Mobile = "2543434343";
			context.Update(updateCustomer);
			context.SaveChanges();

			List<Customer> customerList = context.Customers.ToList();
			foreach (Customer customer in customerList)
			{
				Console.WriteLine("------------------------------------------");
				Console.WriteLine($"Name: {customer.FirstName}, {customer.LastName}");
				Console.WriteLine($"Email: {customer.Email}");
				Console.WriteLine($"Mobile: {customer.Mobile}");
				Console.WriteLine("------------------------------------------");

				foreach (var order in customer.Orders)
				{
					Console.WriteLine($"Product Name: {order.Product.Name}");
					Console.WriteLine($"Price: {order.Product.Price}");
					Console.WriteLine($"Quantity: {order.Quantity}");
					Console.WriteLine($"Total Amount: {order.Amount}");
				}
			}

			Console.ReadKey();
		}
	}
}