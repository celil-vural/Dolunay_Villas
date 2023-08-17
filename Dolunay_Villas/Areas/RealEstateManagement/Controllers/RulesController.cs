using Dolunay_Villas.Areas.RealEstateManagement.Models.Rules;
using Dolunay_Villas.Models;
using Entity.Dtos.RealEstateManagement.Rules;
using Entity.Enums;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using Service.Contract.RealEstateManagement;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    [Authorize(Policy = nameof(Powers.CanManageRealEstateRules))]
    public class RulesController : Controller
    {
        private readonly IRealEstateRulesService _service;
        private readonly IFontAwesomeService _fontAwesomeService;
        private readonly IIconService _iconService;
        public RulesController(IRealEstateRulesService realEstateRulesService, IFontAwesomeService fontAwesomeService, IIconService iconService)
        {
            _service = realEstateRulesService;
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
            var model = new RealEstateRulesListViewModel
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
            var model = new RulesInsertionModel
            {
                LocalIcons = localIcons,
                FontAwesomeIcons = icons
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] RulesInsertionModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dtoForInsertion = model.DtoForInsertion;
                    dtoForInsertion.CreatedByUser = User.Identity?.Name ?? "";
                    dtoForInsertion.UpdatedByUser = User.Identity?.Name ?? "";
                    _service.CreateWithDto(dtoForInsertion);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    var icons = await _fontAwesomeService.GetAllFreeIcons();
                    var localIcons = _iconService.GetList();
                    var newModel = new RulesInsertionModel
                    {
                        DtoForInsertion = new RulesDtoForInsertion
                        {
                            FontAwesomeIcon = null,
                            LocalIconId = null,
                            Title_En = model.DtoForInsertion.Title_En,
                            Title_Tr = model.DtoForInsertion.Title_Tr,
                        },
                        LocalIcons = localIcons,
                        FontAwesomeIcons = icons
                    };
                    ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
                    return View(newModel);
                }
            }
            return View(model);
        }
        public async Task<IActionResult> Update([FromRoute(Name = "id")] int id)
        {
            var icons = await _fontAwesomeService.GetAllFreeIcons();
            var localIcons = _iconService.GetList();
            var entity = _service.GetEntity<RulesDtoForUpdate>(id);
            var model = new RulesUpdateModel
            {
                DtoForUpdate = entity ?? new(),
                LocalIcons = localIcons,
                FontAwesomeIcons = icons
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] RulesUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dtoForUpdate = model.DtoForUpdate;
                    dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "";
                    _service.Update(dtoForUpdate);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    var icons = await _fontAwesomeService.GetAllFreeIcons();
                    var localIcons = _iconService.GetList();
                    var newModel = new RulesUpdateModel
                    {
                        DtoForUpdate = model.DtoForUpdate,
                        LocalIcons = localIcons,
                        FontAwesomeIcons = icons
                    };
                    ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
                    return View(newModel);
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
                ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
