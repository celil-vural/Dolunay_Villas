using Dolunay_Villas.Areas.Admin.Models.Icon;
using Dolunay_Villas.Models;
using Entity.Dtos.Icon;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace Dolunay_Villas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IconController : Controller
    {
        private readonly IIconService _service;

        public IconController(IIconService service)
        {
            _service = service;
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
            var model = new IconListViewModel
            {
                Entities = entity,
                Pagination = pagination
            };
            return View("Index", model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] IconDtoForInsertion model, IFormFile formFile)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "uploads", "icons");

                    if (formFile != null && formFile.Length > 0 && formFile.Length <= 3 * 1024 * 1024)
                    {
                        await _service.ConvertIconAsync(formFile, model.FileName, uploadsFolder);
                        model.CreatedByUser = User.Identity?.Name ?? "null";
                        model.FilePath = Path.Combine("images", "uploads", "icons");
                        _service.CreateWithDto(model);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("Icon", "The icon size should be between 10 kb and 3 mb");
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromForm(Name = "Entity")] int id, [FromForm(Name = "EntityName")] string name)
        {
            try
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "uploads", "icons");
                name = String.Concat(name, ".webp");
                var path = Path.Combine(uploadsFolder, name);
                _service.Delete(id);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update([FromRoute(Name = "id")] int id)
        {
            var entity = _service.GetEntity<IconDtoForUpdate>(id);
            var model = new IconUpdateModel
            {
                IconDtoForUpdate = entity,
            };
            return View("Update", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] IconUpdateModel model, [FromForm(Name = "formFile")] IFormFile? formFile)
        {
            if (ModelState.IsValid)
            {
                if (model.IconDtoForUpdate == null)
                {
                    ModelState.AddModelError("", "The model is null");
                    return View(model);
                }
                if (string.Equals(model.OldFileName, model.IconDtoForUpdate.FileName, StringComparison.OrdinalIgnoreCase) && formFile == null)
                {
                    return RedirectToAction("Index");
                }
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "uploads", "icons");
                try
                {
                    var dtoForUpdate = model.IconDtoForUpdate;
                    if (formFile == null && model.OldFileName != dtoForUpdate.FileName)
                    {
                        dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "null";
                        await _service.ChangeNameFile(model.OldFileName, dtoForUpdate.FileName, uploadsFolder);
                        _service.Update(dtoForUpdate);
                    }
                    else if (formFile.Length > 0 && formFile.Length <= 3 * 1024 * 1024)
                    {
                        dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "null";
                        await _service.DeleteIconAsync(model.OldFileName, uploadsFolder);
                        await _service.ConvertIconAsync(formFile, dtoForUpdate.FileName, uploadsFolder);
                        _service.Update(dtoForUpdate);
                    }
                    else
                    {
                        ModelState.AddModelError("Icon", "The icon size should be between 10 kb and 3 mb");
                        return View(model);
                    }
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(model);
        }
    }
}
