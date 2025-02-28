

using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
  public class Order
  {
    [Required(ErrorMessage = "Order Id Details are required")]
    int OrderId { get; set; }
    
    [Required(ErrorMessage = "User Id Details are required")]
    int UserId { get; set; }

    [Required(ErrorMessage = "Order Details are required")]
    List<OrderDetails> LstOrderDetails { get; set; }
  }
}