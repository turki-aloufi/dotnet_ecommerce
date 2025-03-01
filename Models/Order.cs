

using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
  public class Order
  {
    [Required(ErrorMessage = "Order Id Details are required")]
    public int OrderId { get; set; }

    [Required(ErrorMessage = "User Id Details are required")]
    public int UserId { get; set; }

    // [Required(ErrorMessage = "Order Details are required")]
    // public List<OrderDetails> LstOrderDetails { get; set; }
    
  }
}