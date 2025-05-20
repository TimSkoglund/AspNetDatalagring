using System.ComponentModel.DataAnnotations;

namespace Presentation.Models;

public class SignInViewModel
{
    [Required]
    [RegularExpression("^$", ErrorMessage = "Invaled email address")]
    [Display(Name = "Email", Prompt = "Enter email address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required]
    [RegularExpression("^$", ErrorMessage = "Invaled password")]
    [Display(Name = "Password", Prompt = "Enter password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    public bool IsPersistent { get; set; }
}
