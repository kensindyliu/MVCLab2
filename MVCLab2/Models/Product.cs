﻿using System;
namespace MVCLab2.Models
{
	public class Product
	{
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(int productId, string name, string description, decimal price)
        {
            ProductID = productId;
            Name = name;
            Description = description;
            Price = price;
        }

        public Product()
		{
		}
	}
}

