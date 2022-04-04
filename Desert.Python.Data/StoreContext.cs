using Desert.Python.Domain.catalog;
using Desert.Python.Domain.orders;
using Microsoft.EntityFrameworkCore;

namespace Desert.Python.Data
{
	public class StoreContext : DbContext
	{
		public StoreContext(DbContextOptions<StoreContext> options) : base(options)
		{
		}

		public DbSet<Item> Items { get; set; }

		public DbSet<Order> Orders { get; set; }
	}
}