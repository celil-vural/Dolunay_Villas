using Dolunay_Villas.Areas.RealEstateManagement.Models.BedTypes;
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
        private readonly IIconService _iconService;
        public BedTypesController(IRealEstateBedTypesService service, IRealEstateItemTypesService itemTypeService, IRealEstateValueTypesService valueTypeService, IFontAwesomeService fontAwesomeService, IIconService iconService)
        {
            _service = service;
            _itemTypeService = itemTypeService;
            _valueTypeService = valueTypeService;
            _fontAwesomeService = fontAwesomeService;
            _iconService = iconService;
        }

        public IActionResult Index([FromQuery] PageRequestParameters? p)
        {
            p ??= new()
            {
                PageNumber = 1,
                PageSize = 10
            };
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
            var icons = await _fontAwesomeService.GetAllFreeIcons();
            var localIcons = _iconService.GetList();
            var model = new BedTypesInsertionModel
            {
                ItemTypeOptions = new SelectList(itemTypes, "Id", "Name"),
                ValueTypeOptions = new SelectList(valueTypes, "Id", "Name"),
                LocalIcons = localIcons,
                FontAwesomeIcons = icons
            };
            return View("Create", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] BedTypesInsertionModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dtoForInsertion = model.BedTypesDtoForInsertion;
                    model.BedTypesDtoForInsertion.CreatedByUser = User.Identity?.Name ?? "";
                    model.BedTypesDtoForInsertion.UpdatedByUser = User.Identity?.Name ?? "";
                    _service.CreateWithDto(model.BedTypesDtoForInsertion);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    var icons = await _fontAwesomeService.GetAllFreeIcons();
                    var localIcons = _iconService.GetList();
                    var itemTypes = _itemTypeService.GetList();
                    var valueTypes = _valueTypeService.GetList();
                    var newModel = new BedTypesInsertionModel
                    {
                        BedTypesDtoForInsertion = new BedTypesDtoForInsertion
                        {
                            Title_En = model.BedTypesDtoForInsertion.Title_En,
                            Title_Tr = model.BedTypesDtoForInsertion.Title_Tr,
                        },
                        LocalIcons = localIcons,
                        FontAwesomeIcons = icons,
                        ItemTypeOptions = new SelectList(itemTypes, "Id", "Name"),
                        ValueTypeOptions = new SelectList(valueTypes, "Id", "Name"),
                    };
                    ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
                    return View(newModel);
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
            var icons = await _fontAwesomeService.GetAllFreeIcons();
            var localIcons = _iconService.GetList();
            var model = new BedTypesUpdateModel
            {
                BedTypesDtoForUpdate = entity ?? new(),
                ItemTypeOptions = new SelectList(itemTypes, "Id", "Name", entity!.ItemTypeKey),
                ValueTypeOptions = new SelectList(valueTypes, "Id", "Name", entity.ValueTypeKey),
                LocalIcons = localIcons,
                FontAwesomeIcons = icons
            };
            return View("Update", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] BedTypesUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dtoForUpdate = model.BedTypesDtoForUpdate;
                    dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "";
                    _service.Update(dtoForUpdate);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    var icons = await _fontAwesomeService.GetAllFreeIcons();
                    var localIcons = _iconService.GetList();
                    var newModel = new BedTypesUpdateModel
                    {
                        BedTypesDtoForUpdate = model.BedTypesDtoForUpdate,
                        LocalIcons = localIcons,
                        FontAwesomeIcons = icons
                    };
                    ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
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
                ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
