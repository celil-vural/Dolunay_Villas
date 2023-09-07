using Dolunay_Villas.Models;
using Entity.Dtos.Villas;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using StoreApp.Models;

namespace Dolunay_Villas.Controllers
{
    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;

        public VillaController(IVillaService villaService)
        {
            _villaService = villaService;
        }

        public IActionResult Index()
        {
            var villasDto = _villaService.GetAll()?.ToList() ?? new List<VillaDto>();
            var pagination = new Pagination()
            {
                CurrentPage = 1,
                ItemsPerPage = 10,
                TotalItems = villasDto?.Count() ?? 0
            };
            var model = new ModelForVilla()
            {
                villas = villasDto!,
                villaRequestParameters = null,
                Pagination = pagination
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([FromForm] VillaRequestParameters v)
        {
            var villasDto = _villaService.GetAllWithParameters(v)?.ToList() ?? new List<VillaDto>();
            var pagination = new Pagination()
            {
                CurrentPage = v.PageNumber,
                ItemsPerPage = v.PageSize,
                TotalItems = villasDto?.Count() ?? 0
            };
            var model = new ModelForVilla()
            {
                villaRequestParameters = v,
                villas = villasDto!,
                Pagination = pagination
            };
            return View(model);
        }
        public IActionResult Get([FromRoute(Name = "id")] string name)
        {
            var villaDto = _villaService.GetByName(name);
            var model = new VillaGetModel()
            {
                Villa = villaDto
            };
            return View(model);
        }
    }
}
