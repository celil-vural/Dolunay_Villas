using Dolunay_Villas.Areas.RealEstateManagement.Models.HeatingOptions;
using Dolunay_Villas.Models;
using Entity.Dtos.RealEstateManagement.HeatingOptions;
using Entity.Enums;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contract.RealEstateManagement;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    [Authorize(Policy = nameof(Powers.CanManagerealEstateHeatingOptions))]
    public class HeatingOptionsController : Controller
    {
        private readonly IRealEstateHeatingOptionsService _service;
        public HeatingOptionsController(IRealEstateHeatingOptionsService realEstateHeatingOptionsService)
        {
            _service = realEstateHeatingOptionsService;
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
            var entity = _service.GetWithDetail(p)?.ToList() ?? new();
            var pagination = new Pagination
            {
                CurrentPage = p.PageNumber,
                ItemsPerPage = p.PageSize,
                TotalItems = _service.GetList()?.Count() ?? 0
            };
            var model = new RealEstateHeatingOptionsListViewModel
            {
                Entities = entity,
                Pagination = pagination
            };
            return View("Index", model);
        }
        public IActionResult Create()
        {
            return View("Create");
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
                    _service.CreateWithDto(dtoForInsertion);
                    return RedirectToAction("Index", "HeatingOptions");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View("Create", dtoForInsertion);
        }
        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            var entity = _service.GetEntity<HeatingOptionsDtoForUpdate>(id);
            return View("Update", entity);
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
                    _service.Update(dtoForUpdate);
                    return RedirectToAction("Index", "HeatingOptions");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View("Update", dtoForUpdate);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromForm(Name = "Entity")] int id)
        {
            try
            {
                _service.Delete(id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
