using Entity.Dtos.Role;
using Entity.Enums;
using Microsoft.AspNetCore.Identity;
using Service.Contract;
using System.Security.Claims;

namespace Service.Concrete
{
    public class RoleService : IRoleService
    {
        private readonly IAuthService _authService;
        private readonly RoleManager<IdentityRole> _roleManager;
        public RoleService(IAuthService authService, RoleManager<IdentityRole> roleManager)
        {
            _authService = authService;
            _roleManager = roleManager;
        }
        public async Task CreateRole(RoleCreateDto roleCreateDto)
        {
            var roleExists = await _roleManager.RoleExistsAsync(roleCreateDto.RoleName);
            if (!roleExists)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(roleCreateDto.RoleName));
                if (result.Succeeded)
                {
                    foreach (var permission in roleCreateDto.Permissions)
                    {
                        var role = await _roleManager.FindByNameAsync(roleCreateDto.RoleName);
                        switch (permission)
                        {
                            case Powers.CanManageRoles:
                                await _roleManager.AddClaimAsync(role, new Claim("CanManageRoles", "true"));
                                break;
                            case Powers.CanManageUsers:
                                await _roleManager.AddClaimAsync(role, new Claim("CanManageUsers", "true"));
                                break;
                            case Powers.CanManageVillas:
                                await _roleManager.AddClaimAsync(role, new Claim("CanManageVillas", "true"));
                                break;
                            case Powers.CanManageDashboard:
                                await _roleManager.AddClaimAsync(role, new Claim("CanManageDashboard", "true"));
                                break;
                            default:
                                throw new Exception("The permission could not found.");
                        }
                    }
                }
                else
                {
                    throw new Exception("The role could not be created.");
                }
            }
            else
            {
                throw new Exception("The role name already exists.");
            }
        }
        public async Task UpdateRole(RoleEditDto roleEditDto)
        {
            var role = await _roleManager.FindByNameAsync(roleEditDto.RoleName);
            if (role == null)
            {
                throw new Exception("The role could not be found.");
            }
            // Mevcut role claimlerini alalım
            var existingClaims = await _roleManager.GetClaimsAsync(role);
            // Mevcut yetkilerin hepsini kaldıralım
            foreach (var claim in existingClaims)
            {
                await _roleManager.RemoveClaimAsync(role, claim);
            }
            // Seçili yetkileri ekleyelim
            foreach (var permission in roleEditDto.PermissionChecks)
            {
                if (permission.Value)
                {
                    var claimType = permission.Key.ToString();
                    await _roleManager.AddClaimAsync(role, new Claim(claimType, "true"));
                }
            }
        }
        public IEnumerable<IdentityRole> Roles => _roleManager.Roles;
        public IEnumerable<Powers> GetPermisions()
        {
            return Enum.GetValues(typeof(Powers)).Cast<Powers>().ToList();
        }
        public async Task DeleteRole(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                throw new Exception("The role could not be found.");
            }

            var result = await _roleManager.DeleteAsync(role);
            if (!result.Succeeded)
            {
                throw new Exception("An error occurred while deleting the role.");
            }
        }


    }
}
