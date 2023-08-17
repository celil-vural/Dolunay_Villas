using Dolunay_Villas.Areas.RealEstateManagement.Models.RealEstateFeatures;
using Dolunay_Villas.Models;
using Entity.Dtos.RealEstateManagement.RealEstateFeatures;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using Service.Contract.RealEstateManagement;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    public class RealEstateFeaturesController : Controller
    {
        private readonly IIconService _iconService;
        private readonly IFontAwesomeService _fontAwesomeService;
        private readonly IRealEstateFeaturesService _service;

        public RealEstateFeaturesController(IRealEstateFeaturesService realEstatePropertyPropertiesService, IFontAwesomeService fontAwesomeService, IIconService iconService)
        {
            _service = realEstatePropertyPropertiesService;
            _fontAwesomeService = fontAwesomeService;
            _iconService = iconService;
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
            var model = new RealEstateFeaturesListViewModel
            {
                Entities = entity,
                Pagination = pagination
            };
            return View("Index", model);
        }
        public async Task<IActionResult> Create()
        {
            var icons = await _fontAwesomeService.GetAllFreeIcons();
            var localIcons = _iconService.GetList();
            var model = new RealEstateFeaturesInsertionModel
            {
                LocalIcons = localIcons,
                FontAwesomeIcons = icons
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] RealEstateFeaturesInsertionModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dtoForInsertion = model.DtoForInsertion;
                    dtoForInsertion.CreatedByUser = User.Identity?.Name ?? "null";
                    _service.CreateWithDto(dtoForInsertion);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    var icons = await _fontAwesomeService.GetAllFreeIcons();
                    var localIcons = _iconService.GetList();
                    var newModel = new RealEstateFeaturesInsertionModel
                    {
                        DtoForInsertion = new RealEstateFeaturesDtoForInsertion
                        {
                            FontAwesomeIcon = null,
                            LocalIconId = null,
                            Title_En = model.DtoForInsertion.Title_En,
                            Title_Tr = model.DtoForInsertion.Title_Tr,
                        },
                        LocalIcons = localIcons,
                        FontAwesomeIcons = icons
                    };
                    ModelState.AddModelError("", e.Message);
                    return View(newModel);
                }
            }
            return View(model);
        }
        public async Task<IActionResult> Update([FromRoute(Name = "id")] int id)
        {
            var icons = await _fontAwesomeService.GetAllFreeIcons();
            var localIcons = _iconService.GetList();
            var entity = _service.GetEntity<RealEstateFeaturesDtoForUpdate>(id);
            var model = new RealEstateFeaturesUpdateModel
            {
                DtoForUpdate = entity ?? new(),
                LocalIcons = localIcons,
                FontAwesomeIcons = icons
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] RealEstateFeaturesUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dtoForUpdate = model.DtoForUpdate;
                    dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "null";
                    _service.Update(dtoForUpdate);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    var icons = await _fontAwesomeService.GetAllFreeIcons();
                    var localIcons = _iconService.GetList();
                    var newModel = new RealEstateFeaturesUpdateModel
                    {
                        DtoForUpdate = model.DtoForUpdate,
                        LocalIcons = localIcons,
                        FontAwesomeIcons = icons
                    };
                    ModelState.AddModelError("", e.Message);
                    return View(newModel);
                }
            }
            return View(model);
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
