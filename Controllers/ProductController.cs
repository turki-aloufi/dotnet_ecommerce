using ECommerceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Controllers
{
  public class ProductController : Controller
  {
    private readonly DataLayer data;  // Declare data as readonly and inject it via the constructor
    private CartItem cartItem = new CartItem();

    // Constructor with dependency injection
    public ProductController(DataLayer dataLayer)
    {
      data = dataLayer;
    }

    public IActionResult ProductListing()
    {
      Console.WriteLine("Product listing");
      return View(data.products);  // Use the injected data object
    }
  }
}
