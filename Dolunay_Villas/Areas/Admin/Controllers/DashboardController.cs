using Entity.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dolunay_Villas.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = nameof(Powers.CanManageDashboard))]
    //[Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            TempData["info"] = $"Welcome back, {DateTime.Now.ToShortTimeString()}";
            return View();
        }
    }
}
