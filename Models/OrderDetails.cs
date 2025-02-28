using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
  class OrderDetails
  {
    [Required(ErrorMessage = "OrderDetail ID is required")]
    int OrderDetailId { get; set; }
    [Required(ErrorMessage = "Order ID is required")]
    int OrderId { get; set; }
    [Required(ErrorMessage = "Product ID is required")]
    int ProductId { get; set; }
    [Required(ErrorMessage = "Quantity is required")]
    int Quantity { get; set; }
    [Required(ErrorMessage = "Sub Total is required")]
    double SubTotal { get; set; }
  }
}