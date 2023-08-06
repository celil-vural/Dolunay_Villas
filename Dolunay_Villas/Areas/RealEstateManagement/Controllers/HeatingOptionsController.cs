using Dolunay_Villas.Areas.RealEstateManagement.Models;
using Dolunay_Villas.Models;
using Entity.Dtos.HeatingOptions;
using Entity.Enums;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    [Authorize(Policy = nameof(Powers.CanManagerealEstateHeatingOptions))]
    public class HeatingOptionsController : Controller
    {
        private readonly IRealEstateHeatingOptionsService _realEstateHeatingOptionsService;
        public HeatingOptionsController(IRealEstateHeatingOptionsService realEstateHeatingOptionsService)
        {
            _realEstateHeatingOptionsService = realEstateHeatingOptionsService;
        }
        public IActionResult Index([FromQuery] PageRequestParameters? p)
        {
            if (p == null)
            {
                p = new()
                {
                    PageNumber = 1,
                    PageSize = 10
                };
            }
            var entity = _realEstateHeatingOptionsService.GetHeatingOptionsWithDetail(p)?.ToList() ?? new();
            var pagination = new Pagination
            {
                CurrentPage = p.PageNumber,
                ItemsPerPage = p.PageSize,
                TotalItems = _realEstateHeatingOptionsService.GetList<HeatingOptionsDto>()?.Count() ?? 0
            };
            var model = new RealEstateHeatingOptionsListViewModel
            {
                Entities = entity,
                Pagination = pagination
            };
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] HeatingOptionsDtoForInsertions dtoForInsertion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dtoForInsertion.CreatedByUser = User.Identity?.Name ?? "null";
                    _realEstateHeatingOptionsService.CreateWithDto(dtoForInsertion);
                    return RedirectToAction("Index", "HeatingOptions");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(dtoForInsertion);
        }
        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            var entity = _realEstateHeatingOptionsService.GetEntity<HeatingOptionsDtoForUpdate>(id);
            return View(entity);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromForm] HeatingOptionsDtoForUpdate dtoForUpdate)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "null";
                    _realEstateHeatingOptionsService.Update(dtoForUpdate);
                    return RedirectToAction("Index", "HeatingOptions");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(dtoForUpdate);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromForm(Name = "HeatingOptions")] int id)
        {
            try
            {
                _realEstateHeatingOptionsService.Delete(id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index", "HeatingOptions");
        }

    }
}
