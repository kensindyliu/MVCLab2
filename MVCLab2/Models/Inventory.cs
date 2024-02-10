using System;
namespace MVCLab2.Models
{
	public class Inventory
	{
        public int InventoryID { get; set; }
        public int ProductID { get; set; }
        public int StockQuantity { get; set; }

        public static List<Product> Products = new();

        public Inventory(int inventoryID, int productID, int stockQuantity)
        {
            InventoryID = inventoryID;
            ProductID = productID;
            StockQuantity = stockQuantity;
        }
        public Inventory()
		{
		}


    }
}

