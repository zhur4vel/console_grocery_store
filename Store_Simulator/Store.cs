using System;
using System.Collections.Generic;
using System.Linq;

namespace store_simulator
{
    public class Store
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public List<string> GetCategories()
        {
            return Products.Select(p => p.Category).Distinct().ToList();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            return Products.Where(p => p.Category == category).ToList();
        }

        public void DisplayProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                string unit = product.Unit == UnitType.PerKg ? "per kg" : "each";
                Console.WriteLine($"{product.Id}. {product.Name} - {product.Price.ToString("C")} ({unit})");
            }
        }
    }
}
