using Microsoft.AspNetCore.Mvc;

namespace Dolunay_Villas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
