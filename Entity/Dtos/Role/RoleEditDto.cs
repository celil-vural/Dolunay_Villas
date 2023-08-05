using Entity.Enums;
namespace Entity.Dtos.Role
{
    public record RoleEditDto : RoleDto
    {
        public Dictionary<Powers, bool> PermissionChecks { get; set; } = new();
    }
}
