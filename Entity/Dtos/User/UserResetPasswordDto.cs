using System.ComponentModel.DataAnnotations;

namespace Entity.Dtos.User
{
    public record UserResetPasswordDto
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "User name is required")]
        public string? UserName { get; init; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; init; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; init; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match")]
        public string? ConfirmPassword { get; init; }
    }
}
