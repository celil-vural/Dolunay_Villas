using Dolunay_Villas.Areas.RealEstateManagement.Models.RoomFeatures;
using Dolunay_Villas.Models;
using Entity.Dtos.RealEstateManagement.RoomFeatures;
using Entity.Enums;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contract.RealEstateManagement;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    [Authorize(Policy = nameof(Powers.CanManageRealEstateRoomFeatures))]
    public class RoomFeaturesController : Controller
    {
        private readonly IRealEstateRoomFeaturesService _realEstateRoomFeaturesService;

        public RoomFeaturesController(IRealEstateRoomFeaturesService realEstateRoomFeaturesService)
        {
            _realEstateRoomFeaturesService = realEstateRoomFeaturesService;
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
            var entity = _realEstateRoomFeaturesService.GetWithDetail(p)?.ToList() ?? new();
            var pagination = new Pagination
            {
                CurrentPage = p.PageNumber,
                ItemsPerPage = p.PageSize,
                TotalItems = _realEstateRoomFeaturesService.GetList()?.Count() ?? 0
            };
            var model = new RealEstateRoomFeaturesListViewModel
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
        public IActionResult Create([FromForm] RoomFeaturesDtoForInsertions dtoForInsertion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dtoForInsertion.CreatedByUser = User.Identity?.Name ?? "";
                    dtoForInsertion.UpdatedByUser = User.Identity?.Name ?? "";
                    _realEstateRoomFeaturesService.CreateWithDto(dtoForInsertion);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
                }
            }
            return View("Create", dtoForInsertion);
        }
        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            var entity = _realEstateRoomFeaturesService.GetEntity<RoomFeaturesDtoForUpdate>(id);
            return View("Update", entity);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromForm] RoomFeaturesDtoForUpdate dtoForUpdate)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "";
                    _realEstateRoomFeaturesService.Update(dtoForUpdate);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
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
                _realEstateRoomFeaturesService.Delete(id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index", "RoomFeatures");
        }
    }
}
