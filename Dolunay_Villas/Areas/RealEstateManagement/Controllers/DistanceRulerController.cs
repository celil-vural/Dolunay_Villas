using Dolunay_Villas.Areas.RealEstateManagement.Models.DistanceRuler;
using Dolunay_Villas.Models;
using Entity.Dtos.RealEstateManagement.DistanceRuler;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Service.Contract.RealEstateManagement;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    public class DistanceRulerController : Controller
    {
        private readonly IRealEstateDistanceRulerService _service;
        private readonly IRealEstateRegionService _regionService;
        private readonly IRealEstateDistancesService _distanceService;
        private readonly IRealEstateLocationTypeService _locationTypeService;
        public DistanceRulerController(IRealEstateDistanceRulerService service, IRealEstateRegionService regionService, IRealEstateDistancesService distanceService, IRealEstateLocationTypeService locationTypeService)
        {
            _service = service;
            _regionService = regionService;
            _distanceService = distanceService;
            _locationTypeService = locationTypeService;
        }
        public IActionResult Index([FromQuery] PageRequestParameters? r)
        {
            r ??= new()
            {
                PageNumber = 1,
                PageSize = 10
            };
            var entity = _service.GetWithDetail(r)?.ToList() ?? new();
            var pagination = new Pagination
            {
                CurrentPage = r.PageNumber,
                ItemsPerPage = r.PageSize,
                TotalItems = _service.GetList()?.Count() ?? 0
            };
            var model = new DistanceRulerListViewModel
            {
                Entities = entity,
                Pagination = pagination
            };
            return View(model);
        }
        public IActionResult Create()
        {
            var distances = _distanceService.GetList()?.ToHashSet() ?? new();
            var regions = _regionService.GetList()?.ToHashSet() ?? new();
            var locationTypes = _locationTypeService.GetList()?.ToHashSet() ?? new();
            var model = new DistanceRulerInsertionModel
            {
                Distances = distances,
                Regions = regions,
                LocationTypes = locationTypes
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] DistanceRulerInsertionModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dtoInsertion = model.DtoInsertion;
                    dtoInsertion.CreatedByUser = User.Identity?.Name ?? "";
                    dtoInsertion.UpdatedByUser = User.Identity?.Name ?? "";
                    var entity = _service.CreateWithDto(dtoInsertion);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
                    var distances = _distanceService.GetList()?.ToHashSet() ?? new();
                    var regions = _regionService.GetList()?.ToHashSet() ?? new();
                    var locationTypes = _locationTypeService.GetList()?.ToHashSet() ?? new();
                    var newModel = new DistanceRulerInsertionModel
                    {
                        DtoInsertion = model.DtoInsertion,
                        Distances = distances,
                        Regions = regions,
                        LocationTypes = locationTypes
                    };
                    return View(newModel);
                }
            }
            return View(model);
        }
        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            var entity = _service.GetEntity<DistanceRulerDtoForUpdate>(id);
            var distances = _distanceService.GetList()?.ToHashSet() ?? new();
            var regions = _regionService.GetList()?.ToHashSet() ?? new();
            var locationTypes = _locationTypeService.GetList()?.ToHashSet() ?? new();
            var model = new DistanceRulerUpdateModel
            {
                DtoForUpdate = entity ?? new(),
                Distances = distances,
                Regions = regions,
                LocationTypes = locationTypes
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(DistanceRulerUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dtoUpdate = model.DtoForUpdate;
                    dtoUpdate.UpdatedByUser = User.Identity?.Name ?? "";
                    _service.CreateWithDto(dtoUpdate);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
                    var distances = _distanceService.GetList()?.ToHashSet() ?? new();
                    var regions = _regionService.GetList()?.ToHashSet() ?? new();
                    var locationTypes = _locationTypeService.GetList()?.ToHashSet() ?? new();
                    var newModel = new DistanceRulerUpdateModel
                    {
                        DtoForUpdate = model.DtoForUpdate,
                        Distances = distances,
                        Regions = regions,
                        LocationTypes = locationTypes
                    };
                    return View(newModel);
                }
            }
            return View(model);
        }
        public IActionResult Delete([FromForm(Name = "Entity")] int id)
        {
            try
            {
                _service.Delete(id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
