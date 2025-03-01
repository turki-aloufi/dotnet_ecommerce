using System.Collections.Generic;

namespace ECommerceProject.Models
{
    public class CartViewModel
    {
        public List<CartItem>? CartItems { get; set; }  // List of cart items
        public double TotalPrice { get; set; }  // Total price of all items in the cart
    }
}
