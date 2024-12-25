using System.ComponentModel.DataAnnotations;

namespace BlazorApp5
{
    public class Person
    {
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@".*@.*", ErrorMessage = "Input must include an '@' symbol.")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
