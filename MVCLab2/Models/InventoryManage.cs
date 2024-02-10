using System;
using System.Collections.Generic;

namespace MVCLab2.Models
{
	public class InventoryManage
	{
		public static List<Product> Products = new();
		public static List<Inventory> Inventories = new();

		public InventoryManage()
		{

		}

        public IEnumerable<dynamic> GetAllProducts()
        {
            //this test is for test only
            if(Products.Count == 0 && Inventories.Count == 0)
            {
                Products.Add(new Product { ProductID = 1, Name = "Product 1", Description = "Description 1", Price = 1 });
                Products.Add(new Product { ProductID = 2, Name = "Product 2", Description = "Description 2", Price = 2 });
                //Products.Add(new Product { ProductID = 3, Name = "Product 3", Description = "Description 3", Price = 3 });
                //Products.Add(new Product { ProductID = 4, Name = "Product 4", Description = "Description 4", Price = 4 });

                Inventories.Add(new Inventory { InventoryID = 1, ProductID = 1, StockQuantity = 10 });
                Inventories.Add(new Inventory { InventoryID = 2, ProductID = 2,  StockQuantity = 20 });
                //Inventories.Add(new Inventory { InventoryID = 3, ProductID = 3,  StockQuantity = 30 });
                //Inventories.Add(new Inventory { InventoryID = 4, ProductID = 4,  StockQuantity = 40 });
            }

            return QeuryProducts();
        }

        private IEnumerable<dynamic> QeuryProducts()
        {
            var query = from product in Products
                        join inv in Inventories on product.ProductID equals inv.ProductID
                        select new
                        {
                            product.ProductID,
                            product.Name,
                            product.Price,
                            product.Description,
                            inv.InventoryID,
                            inv.StockQuantity
                        };
            return query.ToList();
        }

        public IEnumerable<dynamic> Delete(int productID)
        {
            Products.RemoveAt(Products.FindIndex(product => product.ProductID == productID));
            Inventories.RemoveAt(Inventories.FindIndex(inventory => inventory.ProductID == productID));

            return QeuryProducts();
        }

        public void AddProduct(Product product, int quantity)
        {
            Products.Add(product);
            int maxID = Inventories.Max(inve => inve.InventoryID);
            Inventory inventory = new Inventory { InventoryID = maxID+1, ProductID = product.ProductID, StockQuantity = quantity };
        }

        public void AddProduct(string productName, string price, string description, string quantity)
        {
            int productId = Products.Max(prod => prod.ProductID) + 1;
            Products.Add(new Product { ProductID = productId, Name = productName, Description = description, Price =int.Parse(price) });
            int inventoryID = Inventories.Max(inve => inve.InventoryID) + 1;
            Inventories.Add(new Inventory { InventoryID = inventoryID, ProductID = productId, StockQuantity = int.Parse(quantity) });
        }

    }




}
