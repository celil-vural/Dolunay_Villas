using Dolunay_Villas.Areas.RealEstateManagement.Models.CreateRealEstate;
using Microsoft.AspNetCore.Mvc;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    public class CreateRealEstateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(CreateRealEstateInsertionModel model)
        {
            return View();
        }
    }
}
