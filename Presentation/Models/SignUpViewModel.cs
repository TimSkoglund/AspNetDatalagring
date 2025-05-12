using System.ComponentModel.DataAnnotations;

namespace Presentation.Models;

public class SignUpViewModel
{
    [Required]
    [DataType(DataType.Text)]  //här 3:22
    public string FirstName { get; set; } = null!;

    [Required]
    [DataType(DataType.Text)]
    public string LastName { get; set; } = null!;

    [Required]
    [RegularExpression(@"")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required]
    [RegularExpression(@"")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Required]
    [Compare(nameof(Password))]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = null!;

    [Range(typeof(bool), "true", "true")]
    public bool TermsAndCondition { get; set; }
}
