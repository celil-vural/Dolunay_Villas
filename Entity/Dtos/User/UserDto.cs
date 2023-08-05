using System.ComponentModel.DataAnnotations;
namespace Entity.Dtos.User
{
    public record UserDto
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "User name is required")]
        public string? UserName { get; init; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; init; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number is required")]
        public string? PhoneNumber { get; init; }
        public HashSet<string> Roles { get; set; } = new HashSet<string>();
    }
}