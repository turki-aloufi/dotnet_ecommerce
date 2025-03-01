using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
  public class CartItem
  {
    [Required(ErrorMessage = "Product Id is required")]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Product Name is required")]
    public string? ProductName { get; set; }

    [Required(ErrorMessage = "Quantity is required")]
    public int Quantity { get; set; }

    [Required(ErrorMessage = "Sub Total is required")]
    public double SubTotal { get; set; }
  }
}