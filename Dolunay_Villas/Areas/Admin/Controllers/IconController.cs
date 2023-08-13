using Dolunay_Villas.Areas.Admin.Models;
using Dolunay_Villas.Models;
using Entity.Dtos.Photo;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace Dolunay_Villas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IconController : Controller
    {
        private readonly IPhotoService _service;

        public IconController(IPhotoService photoService)
        {
            _service = photoService;
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
            var entity = _service.GetWithDetail(r)?.ToList() ?? new();
            var pagination = new Pagination
            {
                CurrentPage = r.PageNumber,
                ItemsPerPage = r.PageSize,
                TotalItems = _service.GetList()?.Count() ?? 0
            };
            var model = new PhotoListViewModel
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
        public async Task<IActionResult> Create([FromForm] PhotoDtoInsertion model, IFormFile formFile)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "uploads");

                    if (formFile != null && formFile.Length > 0 && formFile.Length <= 3 * 1024 * 1024)
                    {
                        await _service.ConvertPhotoAsync(formFile, model.FileName, uploadsFolder);
                        model.CreatedByUser = User.Identity?.Name ?? "null";
                        _service.CreateWithDto(model);

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("Photo", "The photo size should be between 10 kb and 3 mb");
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
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "uploads");
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
            var entity = _service.GetEntity<PhotoDtoUpdate>(id);
            var model = new PhotoUpdateModel
            {
                PhotoDtoUpdate = entity,
            };
            return View("Update", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] PhotoUpdateModel model, [FromForm(Name = "formFile")] IFormFile? formFile)
        {
            if (ModelState.IsValid)
            {
                if (model.PhotoDtoUpdate == null)
                {
                    ModelState.AddModelError("", "The model is null");
                    return View(model);
                }
                if (string.Equals(model.OldFileName, model.PhotoDtoUpdate.FileName, StringComparison.OrdinalIgnoreCase) && formFile == null)
                {
                    return RedirectToAction("Index");
                }
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "uploads");
                try
                {
                    if (formFile == null && model.OldFileName != model.PhotoDtoUpdate.FileName)
                    {
                        model.PhotoDtoUpdate.UpdatedByUser = User.Identity?.Name ?? "null";
                        await _service.ChangeNameFile(model.OldFileName, model.PhotoDtoUpdate.FileName, uploadsFolder);
                        _service.Update(model.PhotoDtoUpdate);
                    }
                    else if (formFile.Length > 0 && formFile.Length <= 3 * 1024 * 1024)
                    {
                        model.PhotoDtoUpdate.UpdatedByUser = User.Identity?.Name ?? "null";
                        await _service.DeletePhotoAsync(model.OldFileName, uploadsFolder);
                        await _service.ConvertPhotoAsync(formFile, model.PhotoDtoUpdate.FileName, uploadsFolder);
                        _service.Update(model.PhotoDtoUpdate);
                    }
                    else
                    {
                        ModelState.AddModelError("Photo", "The photo size should be between 10 kb and 3 mb");
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
