using Entity.Dtos.Role;
using Entity.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace StoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    [Authorize(Policy = nameof(Powers.CanManageRoles))]
    public class RoleController : Controller
    {
        private readonly IAuthService _authService;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IRoleService _roleService;
        public RoleController(IAuthService authService, RoleManager<IdentityRole> roleManager, IRoleService roleService)
        {
            _authService = authService;
            _roleManager = roleManager;
            _roleService = roleService;
        }

        public IActionResult Index()
        {
            return View(_authService.Roles);
        }
        public IActionResult Create()
        {
            var model = new RoleCreateDto()
            {
                Permissions = GetPermissions()
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] RoleCreateDto model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _roleService.CreateRole(model);
                    return RedirectToAction("Index", "Role");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                    return View(model);
                }
            }

            model.Permissions = GetPermissions();
            return View(model);
        }

        private List<Powers> GetPermissions()
        {
            return _roleService.GetPermisions().ToList();
        }

        [HttpGet]
        public async Task<IActionResult> Update([FromRoute(Name = "id")] string id)
        {
            if (id == null) return NotFound();
            var role = await _roleManager.FindByNameAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            var model = new RoleEditDto
            {
                RoleName = role.Name,
                Permissions = GetPermissions(),
                PermissionChecks = new Dictionary<Powers, bool>()
            };

            var claims = await _roleManager.GetClaimsAsync(role);
            foreach (var permission in model.Permissions)
            {
                var permissionClaimType = permission.ToString();
                model.PermissionChecks[permission] = claims.Any(c => c.Type == permissionClaimType);
            }

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Update(RoleEditDto model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model == null) throw new Exception("The model is null.");
                    await _roleService.UpdateRole(model); // UpdateRole metodu çağrılıyor
                    return RedirectToAction("Index", "Role");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                    return View(model);
                }
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteRole([FromForm] RoleDto roleDto)
        {
            if (!ModelState.IsValid || roleDto.RoleName is null) View();
            try
            {
                await _roleService.DeleteRole(roleDto.RoleName);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
        }
    }
}
