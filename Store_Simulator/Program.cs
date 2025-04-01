using System;
using System.Globalization;
using System.Linq;

namespace store_simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            Store store = InitializeStore();
            Cart cart = new Cart();

            RunCustomerMenu(store, cart);
        }

        static Store InitializeStore()
        {
            Store store = new Store();

            store.AddProduct(new Product { Id = 1, Name = "Milk", Price = 1.20m, Category = "Dairy", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 2, Name = "Cheese", Price = 4.99m, Category = "Dairy", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 3, Name = "Yogurt", Price = 1.00m, Category = "Dairy", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 4, Name = "Butter", Price = 2.75m, Category = "Dairy", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 5, Name = "Cottage Cheese", Price = 3.20m, Category = "Dairy", Unit = UnitType.PerItem });

            store.AddProduct(new Product { Id = 6, Name = "Chicken Breast", Price = 5.50m, Category = "Meat", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 7, Name = "Pork Chops", Price = 6.75m, Category = "Meat", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 8, Name = "Ground Beef", Price = 7.20m, Category = "Meat", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 9, Name = "Bacon", Price = 3.99m, Category = "Meat", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 10, Name = "Sausages", Price = 5.40m, Category = "Meat", Unit = UnitType.PerKg });

            store.AddProduct(new Product { Id = 11, Name = "Apple", Price = 2.00m, Category = "Fruits", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 12, Name = "Banana", Price = 1.80m, Category = "Fruits", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 13, Name = "Orange", Price = 2.50m, Category = "Fruits", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 14, Name = "Grapes", Price = 3.50m, Category = "Fruits", Unit = UnitType.PerKg });

            store.AddProduct(new Product { Id = 15, Name = "Tomato", Price = 2.20m, Category = "Vegetables", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 16, Name = "Potato", Price = 1.10m, Category = "Vegetables", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 17, Name = "Carrot", Price = 1.30m, Category = "Vegetables", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 18, Name = "Onion", Price = 1.00m, Category = "Vegetables", Unit = UnitType.PerKg });

            store.AddProduct(new Product { Id = 19, Name = "Rice", Price = 3.00m, Category = "Grains", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 20, Name = "Pasta", Price = 2.50m, Category = "Grains", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 21, Name = "Oats", Price = 2.80m, Category = "Grains", Unit = UnitType.PerKg });
            store.AddProduct(new Product { Id = 22, Name = "Buckwheat", Price = 3.20m, Category = "Grains", Unit = UnitType.PerKg });

            store.AddProduct(new Product { Id = 23, Name = "Bread", Price = 2.50m, Category = "Bakery", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 24, Name = "Bun", Price = 1.00m, Category = "Bakery", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 25, Name = "Croissant", Price = 1.50m, Category = "Bakery", Unit = UnitType.PerItem });

            store.AddProduct(new Product { Id = 26, Name = "Chips", Price = 2.20m, Category = "Snacks", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 27, Name = "Salted Peanuts", Price = 1.80m, Category = "Snacks", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 28, Name = "Nachos", Price = 3.00m, Category = "Snacks", Unit = UnitType.PerItem });

            store.AddProduct(new Product { Id = 29, Name = "Water 1.5L", Price = 1.00m, Category = "Drinks", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 30, Name = "Cola", Price = 1.70m, Category = "Drinks", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 31, Name = "Juice", Price = 2.20m, Category = "Drinks", Unit = UnitType.PerItem });

            store.AddProduct(new Product { Id = 32, Name = "Beer", Price = 2.50m, Category = "Alcohol", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 33, Name = "Wine", Price = 8.00m, Category = "Alcohol", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 34, Name = "Vodka", Price = 12.00m, Category = "Alcohol", Unit = UnitType.PerItem });

            store.AddProduct(new Product { Id = 35, Name = "Cigarettes Marlboro", Price = 5.80m, Category = "Cigarettes", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 36, Name = "Cigarettes Camel", Price = 5.60m, Category = "Cigarettes", Unit = UnitType.PerItem });

            store.AddProduct(new Product { Id = 37, Name = "Chocolate Bar", Price = 1.50m, Category = "Sweets", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 38, Name = "Gummy Bears", Price = 1.30m, Category = "Sweets", Unit = UnitType.PerItem });
            store.AddProduct(new Product { Id = 39, Name = "Cookies", Price = 2.10m, Category = "Sweets", Unit = UnitType.PerItem });

            return store;
        }

        static void RunCustomerMenu(Store store, Cart cart)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Grocery Store ===");
                Console.WriteLine("1. View categories");
                Console.WriteLine("2. View cart");
                Console.WriteLine("3. Checkout");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine() ?? string.Empty;

                switch (input)
                {
                    case "1":
                        ShowCategories(store, cart);
                        break;
                    case "2":
                        ShowCart(cart);
                        break;
                    case "3":
                        Checkout(cart);
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        Pause();
                        break;
                }
            }
        }

        static void ShowCategories(Store store, Cart cart)
        {
            Console.Clear();
            var categories = store.GetCategories();
            Console.WriteLine("Select a category:");

            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categories[i]}");
            }

            Console.Write("Your choice: ");
            if (int.TryParse(Console.ReadLine(), out int catChoice) && catChoice >= 1 && catChoice <= categories.Count)
            {
                string category = categories[catChoice - 1];
                var products = store.GetProductsByCategory(category);

                Console.Clear();
                Console.WriteLine($"--- {category} ---");
                store.DisplayProducts(products);

                Console.Write("Enter product ID to add to cart: ");
                if (int.TryParse(Console.ReadLine(), out int productId))
                {
                    var selected = products.FirstOrDefault(p => p.Id == productId);
                    if (selected != null)
                    {
                        Console.Write($"Enter quantity ({(selected.Unit == UnitType.PerKg ? "kg" : "items")}): ");
                        if (double.TryParse(Console.ReadLine(), out double quantity) && quantity > 0)
                        {
                            cart.Items.Add(new CartItem { Product = selected, Quantity = quantity });
                            Console.WriteLine("Added to cart.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid quantity.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            else
            {
                Console.WriteLine("Invalid category.");
            }

            Pause();
        }

        static void ShowCart(Cart cart)
        {
            Console.Clear();
            Console.WriteLine("=== Your Cart ===");

            if (cart.Items.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
            }
            else
            {
                foreach (var item in cart.Items)
                {
                    string unitLabel = item.Product.Unit == UnitType.PerKg ? "kg" : "item";
                    string quantityFormatted = item.Quantity % 1 == 0
                        ? ((int)item.Quantity).ToString()
                        : item.Quantity.ToString("0.##");

                    string plural = (item.Quantity > 1) ? "s" : "";

                    Console.WriteLine($"{item.Product.Name} – {quantityFormatted} {unitLabel}{plural} – {(item.Product.Price * (decimal)item.Quantity).ToString("C")}");
                }

                Console.WriteLine($"\nTotal: {cart.GetTotalPrice().ToString("C")}");
            }

            Pause();
        }


        static void Checkout(Cart cart)
        {
            Console.Clear();
            Console.WriteLine("=== Checkout ===");
            Console.WriteLine($"Total to pay: {cart.GetTotalPrice().ToString("C")}");
            Console.WriteLine("Thank you for shopping with us!");

            cart.Items.Clear();
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
