using Dolunay_Villas.Areas.RealEstateManagement.Models;
using Dolunay_Villas.Models;
using Entity.Dtos.Rules;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    public class RulesController : Controller
    {
        private readonly IRealEstateRulesService _realEstateRulesService;
        public RulesController(IRealEstateRulesService realEstateRulesService)
        {
            _realEstateRulesService = realEstateRulesService;
        }
        public IActionResult Index([FromQuery] RealEsateRequestParameters? r)
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
                TotalItems = _realEstateRulesService.GetRules()?.Count() ?? 0
            };
            var model = new RealEstateRulesListViewModel
            {
                Rules = rules,
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
                    _realEstateRulesService.CreateRules(dtoForInsertion);
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
            var rule = _realEstateRulesService.GetRule(id);
            return View(rule);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromForm] RulesDtoForUpdate rulesDtoForUpdate)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _realEstateRulesService.UpdateRules(rulesDtoForUpdate);
                    return RedirectToAction("Index", "Rules");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(rulesDtoForUpdate);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromForm(Name = "Rules")] int id)
        {
            try
            {
                _realEstateRulesService.DeleteRules(id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index", "Rules");
        }
    }
}
