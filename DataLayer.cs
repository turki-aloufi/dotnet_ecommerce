using System.Security.Cryptography.X509Certificates;
using ECommerceProject.Models;
public class DataLayer
{
    // Ensure user is initialized with a default value

    public List<Order> orders = new List<Order>(); 
    public List<OrderDetails> orderDetails = new List<OrderDetails>(); 
    public User user { get; set; } = new User { 
        UserId = 1, 
        Name = "Alice", 
        Email = "alice@example.com", 
        Password = "password123", 
        CreatedAt = DateTime.Now,
        cart = new List<CartItem>() 
    };

    public List<Product> products { get; set; }

    public DataLayer()
    {
        products = new List<Product>
        {
            new Product { ProductId = 1, Name = "Laptop", Category = "Electronics", Price = 999.99, StockQuantity = 100 },
            new Product { ProductId = 2, Name = "Smartphone", Category = "Electronics", Price = 699.99, StockQuantity = 150 },
            new Product { ProductId = 3, Name = "Headphones", Category = "Audio", Price = 149.99, StockQuantity = 200 },
            new Product { ProductId = 4, Name = "Smartwatch", Category = "Wearables", Price = 199.99, StockQuantity = 120 },
            new Product { ProductId = 5, Name = "Tablet", Category = "Electronics", Price = 499.99, StockQuantity = 80 },
            new Product { ProductId = 6, Name = "Gaming Console", Category = "Gaming", Price = 399.99, StockQuantity = 50 },
            new Product { ProductId = 7, Name = "Wireless Speaker", Category = "Audio", Price = 129.99, StockQuantity = 75 },
            new Product { ProductId = 8, Name = "Mechanical Keyboard", Category = "Accessories", Price = 89.99, StockQuantity = 95 },
            new Product { ProductId = 9, Name = "External Hard Drive", Category = "Storage", Price = 59.99, StockQuantity = 110 },
            new Product { ProductId = 10, Name = "4K Monitor", Category = "Computing", Price = 299.99, StockQuantity = 60 }
        };
    }
}
