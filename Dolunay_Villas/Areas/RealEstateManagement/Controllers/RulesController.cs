using Dolunay_Villas.Areas.RealEstateManagement.Models;
using Dolunay_Villas.Areas.RealEstateManagement.Models.Rules;
using Dolunay_Villas.Models;
using Entity.Dtos.RealEstateManagement.Rules;
using Entity.Enums;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using Service.Contract;
using Service.Contract.RealEstateManagement;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    [Authorize(Policy = nameof(Powers.CanManageRealEstateRules))]
    public class RulesController : Controller
    {
        private readonly IRealEstateRulesService _realEstateRulesService;
        private readonly IFontAwesomeService _fontAwesomeService;
        private readonly ILoggerRepository _loggerRepository;
        private readonly IIconService _iconService;
        public RulesController(IRealEstateRulesService realEstateRulesService, ILoggerRepository loggerRepository, IFontAwesomeService fontAwesomeService, IIconService iconService)
        {
            _realEstateRulesService = realEstateRulesService;
            _fontAwesomeService = fontAwesomeService;
            _loggerRepository = loggerRepository;
            _iconService = iconService;
        }
        public IActionResult Index([FromQuery] PageRequestParameters? r)
        {

            if (r == null)
            {
                r = new()
                {
                    PageNumber = 1,
                    PageSize = 10
                };
            }
            var entity = _realEstateRulesService.GetWithDetail(r)?.ToList() ?? new();
            var pagination = new Pagination
            {
                CurrentPage = r.PageNumber,
                ItemsPerPage = r.PageSize,
                TotalItems = _realEstateRulesService.GetList()?.Count() ?? 0
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
                    var dtoForInsertion = model.RulesDtoForInsertion;
                    if (string.IsNullOrEmpty(dtoForInsertion.FontAwesomeIcon) && dtoForInsertion.LocalIconId == null)
                    {
                        throw new Exception("Please select an icon");

                    }
                    if (!(string.IsNullOrEmpty(dtoForInsertion.FontAwesomeIcon)) && !(dtoForInsertion.LocalIconId == null))
                    {
                        throw new Exception("Please just select an icon");
                    }
                    dtoForInsertion.CreatedByUser = User.Identity?.Name ?? "null";
                    _realEstateRulesService.CreateWithDto(dtoForInsertion);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    var icons = await _fontAwesomeService.GetAllFreeIcons();
                    var localIcons = _iconService.GetList();
                    var newModel = new RulesInsertionModel
                    {
                        RulesDtoForInsertion = new RulesDtoForInsertion
                        {
                            FontAwesomeIcon = null,
                            LocalIconId = null,
                            Title_En = model.RulesDtoForInsertion.Title_En,
                            Title_Tr = model.RulesDtoForInsertion.Title_Tr,
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
            var entity = _realEstateRulesService.GetEntity<RulesDtoForUpdate>(id);
            var model = new RulesUpdateModel
            {
                RulesDtoForUpdate = entity ?? new(),
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
                    var dtoForUpdate = model.RulesDtoForUpdate;
                    if (String.IsNullOrEmpty(dtoForUpdate.FontAwesomeIcon) && dtoForUpdate.LocalIconId == null)
                    {
                        throw new Exception("Please select an icon");
                    }
                    if (!(String.IsNullOrEmpty(dtoForUpdate.FontAwesomeIcon)) && !(dtoForUpdate.LocalIconId == null))
                    {
                        throw new Exception("Please just select an icon");
                    }
                    dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "null";
                    _realEstateRulesService.Update(dtoForUpdate);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    var icons = await _fontAwesomeService.GetAllFreeIcons();
                    var localIcons = _iconService.GetList();
                    var newModel = new RulesUpdateModel
                    {
                        RulesDtoForUpdate = model.RulesDtoForUpdate,
                        LocalIcons = localIcons,
                        FontAwesomeIcons = icons
                    };
                    ModelState.AddModelError("", e.Message);
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
                _realEstateRulesService.Delete(id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
