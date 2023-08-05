using Entity.Enums;
using System.ComponentModel.DataAnnotations;
namespace Entity.Dtos.Role
{
    public record RoleDto
    {
        public List<Powers> Permissions { get; set; } = new();
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "RolName is required.")]
        public string RoleName { get; init; } = string.Empty;
    }
}
