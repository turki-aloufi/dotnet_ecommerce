using System.ComponentModel.DataAnnotations;
namespace ECommerceProject.Models
{
  public class Product
  {
    [Required(ErrorMessage = "ProductId is required")]
    int ProductId { get; set; }


    [Required(ErrorMessage = "Name is required")]
    string Name { get; set; }


    [Required(ErrorMessage = "Category is required")]
    string Category { get; set; }


    [Required(ErrorMessage = "Price is required")]
    double Price { get; set; }


    [Required(ErrorMessage = "Stock Quantity is required")]
    int StockQuantity { get; set; }
  }
}