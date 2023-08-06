using Dolunay_Villas.Areas.RealEstateManagement.Models;
using Dolunay_Villas.Models;
using Entity.Dtos.Rules;
using Entity.Enums;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    [Authorize(Policy = nameof(Powers.CanManageRealEstateRules))]
    public class RulesController : Controller
    {
        private readonly IRealEstateRulesService _realEstateRulesService;
        public RulesController(IRealEstateRulesService realEstateRulesService)
        {
            _realEstateRulesService = realEstateRulesService;
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
            var rules = _realEstateRulesService.GetRulesWithDetail(r)?.ToList() ?? new();
            var pagination = new Pagination
            {
                CurrentPage = r.PageNumber,
                ItemsPerPage = r.PageSize,
                TotalItems = _realEstateRulesService.GetList<RulesDto>()?.Count() ?? 0
            };
            var model = new RealEstateRulesListViewModel
            {
                Entities = rules,
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
        public IActionResult Create([FromForm] RulesDtoForInsertion dtoForInsertion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dtoForInsertion.CreatedByUser = User.Identity?.Name ?? "null";
                    _realEstateRulesService.CreateWithDto(dtoForInsertion);
                    return RedirectToAction("Index", "Rules");
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
            var rule = _realEstateRulesService.GetEntity<RulesDtoForUpdate>(id);
            return View(rule);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromForm] RulesDtoForUpdate dtoForUpdate)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "null";
                    _realEstateRulesService.Update(dtoForUpdate);
                    return RedirectToAction("Index", "Rules");
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
        public IActionResult Delete([FromForm(Name = "Rules")] int id)
        {
            try
            {
                _realEstateRulesService.Delete(id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index", "Rules");
        }
    }
}
