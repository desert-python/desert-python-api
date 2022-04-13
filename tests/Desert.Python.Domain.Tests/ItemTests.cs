using System;
using Desert.Python.Domain.catalog;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Desert.Python.Domain.Tests;

[TestClass]
public class ItemTests
{
    [TestMethod]
    public void Can_Create_New_Item()
    {
			var item = new Item("Name", "Description", "Brand", 10.00m);

			Assert.AreEqual("Name", item.Name);
			Assert.AreEqual("Description", item.Description);
			Assert.AreEqual("Brand", item.Brand);
			Assert.AreEqual(10.00m, item.Price);
    }

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Cannot_Create_Rating_With_Invalid_Stars()
		{
			var rating = new Rating(0, "Mike", "Great fit!");
		}
}