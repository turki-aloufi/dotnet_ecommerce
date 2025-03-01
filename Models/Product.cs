using System.ComponentModel.DataAnnotations;
namespace ECommerceProject.Models
{
  public class Product
  {
    [Required(ErrorMessage = "ProductId is required")]
    public int ProductId { get; set; }


    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }


    [Required(ErrorMessage = "Category is required")]
    public string Category { get; set; }


    [Required(ErrorMessage = "Price is required")]
    public double Price { get; set; }


    [Required(ErrorMessage = "Stock Quantity is required")]
    public int StockQuantity { get; set; }
  }
}