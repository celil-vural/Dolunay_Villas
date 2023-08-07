using Dolunay_Villas.Areas.RealEstateManagement.Models;
using Dolunay_Villas.Models;
using Entity.Dtos.RealEstateManagement.BedTypes;
using Entity.Enums;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.Contract;
using Service.Contract.RealEstateManagement;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    [Authorize(Policy = nameof(Powers.CanManageRealEstateBedTypes))]
    public class BedTypesController : Controller
    {
        private readonly IRealEstateBedTypesService _service;
        private readonly IRealEstateItemTypesService _itemTypeService;
        private readonly IRealEstateValueTypesService _valueTypeService;
        private readonly IFontAwesomeService _fontAwesomeService;
        public BedTypesController(IRealEstateBedTypesService service, IRealEstateItemTypesService itemTypeService, IRealEstateValueTypesService valueTypeService, IFontAwesomeService fontAwesomeService)
        {
            _service = service;
            _itemTypeService = itemTypeService;
            _valueTypeService = valueTypeService;
            _fontAwesomeService = fontAwesomeService;
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
            var model = new RealEstateBedTypesListViewModel
            {
                Entities = entity,
                Pagination = pagination
            };
            return View("Index", model);
        }
        public async Task<IActionResult> Create()
        {
            var itemTypes = _itemTypeService.GetList();
            var valueTypes = _valueTypeService.GetList();
            var model = new BedTypesInsertionModel
            {
                ItemTypeOptions = new SelectList(itemTypes, "Id", "Name"),
                ValueTypeOptions = new SelectList(valueTypes, "Id", "Name")
            };
            var icons = await _fontAwesomeService.GetAllFreeIcons();
            ViewBag.Icons = icons;
            return View("Create", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] BedTypesInsertionModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.BedTypesDtoForInsertion.CreatedByUser = User.Identity?.Name ?? "null";
                    _service.CreateWithDto(model.BedTypesDtoForInsertion);
                    return RedirectToAction("Index", "BedTypes");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            model.ItemTypeOptions = new SelectList(_itemTypeService.GetList(), "Id", "Name");
            model.ValueTypeOptions = new SelectList(_valueTypeService.GetList(), "Id", "Name");
            return View(model);
        }
        public async Task<IActionResult> Update([FromRoute(Name = "id")] int id)
        {
            var entity = _service.GetEntity<BedTypesDtoForUpdate>(id);
            var itemTypes = _itemTypeService.GetList();
            var valueTypes = _valueTypeService.GetList();
            var model = new BedTypesUpdateModel
            {
                BedTypesDtoForUpdate = entity ?? new(),
                ItemTypeOptions = new SelectList(itemTypes, "Id", "Name", entity.ItemTypeKey),
                ValueTypeOptions = new SelectList(valueTypes, "Id", "Name", entity.ValueTypeKey)
            };
            var icons = await _fontAwesomeService.GetAllFreeIcons();
            if (entity.IconString != null) icons.Insert(0, entity.IconString);
            ViewBag.Icons = icons;
            return View("Update", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromForm] BedTypesUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.BedTypesDtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "null";
                    _service.Update(model.BedTypesDtoForUpdate);
                    return RedirectToAction("Index", "BedTypes");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View("Update", model);
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
            return RedirectToAction("Index", "BedTypes");
        }
    }
}
