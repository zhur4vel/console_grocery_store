using System.Collections.Generic;
using System.Linq;

namespace store_simulator
{
    public class Cart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public decimal GetTotalPrice()
        {
            return Items.Sum(item => item.Product.Price * (decimal)item.Quantity);
        }
    }
}
