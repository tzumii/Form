using System.ComponentModel.DataAnnotations;

namespace BlazorApp5
{
    public class Person
    {
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@".*@.*", ErrorMessage = "Input must include an '@' symbol.")]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
