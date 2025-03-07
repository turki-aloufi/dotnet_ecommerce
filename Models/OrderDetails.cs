using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
  public class OrderDetails
  {
    [Required(ErrorMessage = "OrderDetail ID is required")]
    public int OrderDetailId { get; set; }
    [Required(ErrorMessage = "Order ID is required")]
    public int OrderId { get; set; }
    [Required(ErrorMessage = "Product ID is required")]
    public int ProductId { get; set; }
    [Required(ErrorMessage = "Quantity is required")]
    public int Quantity { get; set; }
    [Required(ErrorMessage = "Sub Total is required")]
    public double SubTotal { get; set; }
  }
}