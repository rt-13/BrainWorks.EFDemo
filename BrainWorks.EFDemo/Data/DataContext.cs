using Microsoft.EntityFrameworkCore;

namespace BrainWorks.EFDemo
{
	public class DataContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = "Data Source=RT-Adeptus;Initial Catalog=MyShop;Integrated Security=True";
			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}