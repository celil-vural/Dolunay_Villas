using Entity.Dtos.Role;
using Entity.Enums;

namespace Service.Contract
{
    public interface IRoleService
    {
        IEnumerable<Powers> GetPermisions();
        Task CreateRole(RoleCreateDto roleCreateDto);
        Task UpdateRole(RoleEditDto roleEditDto);
        Task DeleteRole(string roleName);
    }
}
