using Desert.Python.Domain.catalog;

namespace Desert.Python.Domain.orders
{
	public class OrderItem
	{
		public int Id { get; set; }
		public Item Item { get; set; }
		public int Quantity { get; set; }
		public decimal Price => Item.Price * Quantity;
	}
}