using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
  public class User
  {
    [Required(ErrorMessage = "User Id is required")]
    public int UserId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "CreatedAt is required")]
    public DateTime CreatedAt { get; set; }

    public List<CartItem>? cart { get; set; } 
  }
}
