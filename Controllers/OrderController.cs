using ECommerceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Controllers
{
  public class OrderController : Controller
  {
    private readonly DataLayer data;
    private CartItem cartItem = new CartItem();

    public OrderController(DataLayer dataLayer)
    {
      data = dataLayer;
    }
    public IActionResult OrderForm()
    {
      return View(cartItem);
    }

    [HttpPost]
    public IActionResult AddToCart(int productId, int quantity)
    {
      if (ModelState.IsValid)
      {
        foreach (var item in data.user.cart)
        {
          Console.WriteLine("in the start" + item.ProductId + " " + item.Quantity + " " + item.SubTotal + " ");
        }
        var product = data.products.FirstOrDefault(p => p.ProductId == productId);
        if (product != null)
        {

          data.user.cart.Add(new CartItem { ProductId = product.ProductId, ProductName = product.Name, Quantity = quantity, SubTotal = product.Price * quantity });
          foreach (var item in data.user.cart)
          {
            Console.WriteLine(item.ProductId + " " + item.Quantity + " " + item.SubTotal + " ");
          }
          cartItem = new CartItem();
        }
      }
      return View("OrderForm", cartItem);
    }
    public IActionResult Cart()
    {
      // Create CartViewModel and pass the list of CartItems and total price
      var cartViewModel = new CartViewModel
      {
        CartItems = data.user.cart,  // List of cart items
        TotalPrice = data.user.cart.Sum(item => item.SubTotal)  // Calculate total price
      };
      return View(cartViewModel);  // Return the view with the CartViewModel
    }

    public IActionResult MakeOrder(List<CartItem> cartItems)
    {
      Console.WriteLine("Making Order");
      Random random = new Random();
      bool validOrderId = false;
      int orderId = 0;
      while (!validOrderId)
      {
        orderId = random.Next(0, 10001);
        if (!data.orders.Any(o => o.OrderId == orderId))
        {
          validOrderId = true;
        }
      }
      data.orders.Add(new Order { OrderId = orderId, UserId = data.user.UserId });
      foreach (var item in data.user.cart)
      {
        bool validOrderDetailsId = false;
        int orderDetailsId = 0;
        while (!validOrderDetailsId)
        {
          orderDetailsId = random.Next(0, 10001);
          if (!data.orderDetails.Any(o => o.OrderDetailId == orderDetailsId))
          {
            validOrderDetailsId = true; // Exit loop if orderDetailsId is unique
          }
        }
        data.orderDetails.Add(new OrderDetails
        {
          OrderDetailId = orderDetailsId,
          OrderId = orderId,
          ProductId = item.ProductId,
          Quantity = item.Quantity,
          SubTotal = item.SubTotal
        });
      }
      data.user.cart.Clear();
      Console.WriteLine(data.orders[0].OrderId);
      Console.WriteLine(data.orderDetails[0].OrderDetailId + " " + data.orderDetails[0].OrderId);
      return RedirectToAction("cart");
    }
    
    
    [HttpGet("Orders/{userId}")]
    public IActionResult OrdersHistory(int userId)
    {
      var userOrders = data.orders
          .Where(o => o.UserId == userId)
          .Select(o => new OrderViewModel
          {
            OrderId = o.OrderId,
            OrderDetails = data.orderDetails
                  .Where(od => od.OrderId == o.OrderId)
                  .Select(od => new OrderDetailViewModel
                  {
                    ProductName = data.products.FirstOrDefault(p => p.ProductId == od.ProductId)?.Name,
                    Quantity = od.Quantity,
                    SubTotal = od.SubTotal
                  }).ToList()
          })
          .ToList();

      return View(userOrders);
    }
  }
}
