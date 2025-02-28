using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
  public class User
  {
    [Required(ErrorMessage = "User Id is required")]
    int UserId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    string Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    string Password { get; set; }

    [Required(ErrorMessage = "CreatedAt is required")]
    DateTime CreatedAt { get; set; }
  }
}
