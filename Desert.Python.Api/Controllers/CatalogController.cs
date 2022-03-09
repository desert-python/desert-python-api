using Microsoft.AspNetCore.Mvc;
using Desert.Python.Domain.catalog;
using Desert.Python.Data;

namespace Desert.Python.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CatalogController : ControllerBase
	{

		private readonly StoreContext _db;

		public CatalogController(StoreContext db)
		{
			_db = db;
		}

		[HttpGet]
		public IActionResult GetItems()
		{
			return Ok(_db.Items);
		}

		[HttpGet("{id:int}")]
		public IActionResult GetItem(int id)
		{
			var item = _db.Items.Find(id);

			if (item == null)
			{
				return NotFound();
			}

			return Ok(item);
		}

		[HttpPost]
		public IActionResult NewItem(Item item)
		{
			return Created("/catalog/42", item);
		}

		[HttpPost("{id:int}/ratings")]
		public IActionResult PostRating(int id, [FromBody] Rating rating)
		{
			var item = new Item("Shirt", "Ohio State shirt", "Nike", 29.99m);
			item.Id = id;
			item.AddRating(rating);

			return Ok(item);
		}

		[HttpPut("{id:int}")]
		public IActionResult UpdateItem(int id, Item item)
		{
			return NoContent();
		}

		[HttpDelete("{id:int}")]
		public IActionResult DeleteItem(int id)
		{
			return NoContent();
		}
	}
}