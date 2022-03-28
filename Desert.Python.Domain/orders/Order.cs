using System.Collections.Generic;
using System.Linq;

namespace Desert.Python.Domain.orders
{
	public class Order
	{
		public int Id { get; set; }
		public List<OrderItem> Items { get; set; }
		public DateTime CreatedDate { get; set; }
		public decimal TotalPrice => Items.Sum(i => i.Price);
	}
}