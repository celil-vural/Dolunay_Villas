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
            var entity = _realEstateRulesService.GetRulesWithDetail(r)?.ToList() ?? new();
            var pagination = new Pagination
            {
                CurrentPage = r.PageNumber,
                ItemsPerPage = r.PageSize,
                TotalItems = _realEstateRulesService.GetList<RulesDto>()?.Count() ?? 0
            };
            var model = new RealEstateRulesListViewModel
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
        public IActionResult Create([FromForm] RulesDtoForInsertion dtoForInsertion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dtoForInsertion.CreatedByUser = User.Identity?.Name ?? "null";
                    _realEstateRulesService.CreateWithDto(dtoForInsertion);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View("Create", dtoForInsertion);
        }
        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            var entity = _realEstateRulesService.GetEntity<RulesDtoForUpdate>(id);
            return View("Update", entity);
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
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
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
