using Dolunay_Villas.Areas.RealEstateManagement.Models;
using Dolunay_Villas.Models;
using Entity.Dtos.RoomFeatures;
using Entity.Enums;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using System.Diagnostics;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    [Authorize(Policy = nameof(Powers.CanManageRoomFeatures))]
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
            var entity = _realEstateRoomFeaturesService.GetRoomFeaturesWithDetail(p)?.ToList() ?? new();
            var pagination = new Pagination
            {
                CurrentPage = p.PageNumber,
                ItemsPerPage = p.PageSize,
                TotalItems = _realEstateRoomFeaturesService.GetList<RoomFeaturesDto>()?.Count() ?? 0
            };
            var model = new RealEstateRoomFeaturesListViewModel
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
        public IActionResult Create([FromForm] RoomFeaturesDtoForInsertions dtoForInsertion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dtoForInsertion.CreatedByUser = User.Identity?.Name ?? "null";
                    _realEstateRoomFeaturesService.CreateWithDto(dtoForInsertion);
                    return RedirectToAction("Index", "RoomFeatures");
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
            var entity = _realEstateRoomFeaturesService.GetEntity<RoomFeaturesDtoForUpdate>(id);
            Debug.WriteLine(entity.CreatedByUser + "\n" + entity.CreatedAt + "****************");
            return View(entity);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromForm] RoomFeaturesDtoForUpdate dtoForUpdate)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Debug.WriteLine(dtoForUpdate.CreatedByUser + "\n" + dtoForUpdate.CreatedAt + "****************");
                    dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "null";
                    _realEstateRoomFeaturesService.Update(dtoForUpdate);
                    return RedirectToAction("Index", "RoomFeatures");
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
        public IActionResult Delete([FromForm(Name = "RoomFeatures")] int id)
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
