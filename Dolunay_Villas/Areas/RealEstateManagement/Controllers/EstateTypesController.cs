using Dolunay_Villas.Areas.RealEstateManagement.Models.EstateTypes;
using Dolunay_Villas.Models;
using Entity.Dtos.Photo;
using Entity.Dtos.RealEstateManagement.EstateTypes;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using Service.Contract.RealEstateManagement;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    public class EstateTypesController : Controller
    {
        private readonly IRealEstateTypesService _service;
        private readonly IPhotoService _photoService;

        public EstateTypesController(IPhotoService photoService, IRealEstateTypesService service)
        {
            _photoService = photoService;
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
            var model = new EstateTypesListViewModel
            {
                Entities = entity,
                Pagination = pagination
            };
            return View("Index", model);
        }
        public IActionResult Create([FromRoute(Name = "id")] int? id)
        {
            if (id != null)
            {
                var model = new EstateTypesInsertionModel
                {
                    DtoForInsertion = new EstateTypesDtoForInsertion()
                    {
                        ParentEstateTypesId = id
                    }
                };
                return View(model);
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] EstateTypesInsertionModel model)
        {
            if (ModelState.IsValid)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "uploads", "estate_types");
                try
                {
                    var dtoForInsertion = model.DtoForInsertion;
                    var formFile = model.Photo;
                    if (formFile == null)
                    {
                        throw new Exception("The photo is required");
                    }
                    if (dtoForInsertion == null)
                    {
                        throw new Exception("The estate type is required");
                    }
                    if (formFile != null && formFile.Length > 0 && formFile.Length <= 3 * 1024 * 1024)
                    {
                        await _photoService.ConvertPhotoAsync(formFile, dtoForInsertion.Name, uploadsFolder);
                        var photoDtoForInsertion = new PhotoDtoInsertion()
                        {
                            CreatedByUser = User.Identity?.Name ?? "null",
                            FilePath = Path.Combine("images", "uploads", "estate_types"),
                            FileName = dtoForInsertion.Name,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now
                        };
                        var photoId = _photoService.CreateWithDto(photoDtoForInsertion);
                        dtoForInsertion.CreatedByUser = User.Identity?.Name ?? "null";
                        dtoForInsertion.PhotoId = photoId;
                        _service.CreateWithDto(dtoForInsertion);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("Photo", "The photo size should be between 10 kb and 3 mb");
                    }
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                    await _photoService.DeletePhotoAsync(model.DtoForInsertion.Name, uploadsFolder);
                }
            }
            return View(model);
        }
        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            var entity = _service.GetEntity<EstateTypesDtoForUpdate>(id);
            var model = new EstateTypesUpdateModel()
            {
                DtoForUpdate = entity ?? new(),
                OldPhotoName = entity?.Name ?? ""
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] EstateTypesUpdateModel model)
        {
            if (ModelState.IsValid)
            {

                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "uploads", "estate_types");
                try
                {
                    var dtoForUpdate = model.DtoForUpdate;
                    var formFile = model.Photo;
                    if (formFile != null && formFile.Length > 0 && formFile.Length <= 3 * 1024 * 1024)
                    {
                        await _photoService.DeletePhotoAsync(model.OldPhotoName, uploadsFolder);
                        await _photoService.ConvertPhotoAsync(formFile, dtoForUpdate.Name, uploadsFolder);
                        var photoEntity = _photoService.GetEntity<PhotoDtoUpdate>(dtoForUpdate.PhotoId);
                        if (photoEntity != null)
                        {
                            photoEntity.UpdatedByUser = User.Identity?.Name ?? "null";
                            photoEntity.FileName = dtoForUpdate.Name;
                            _photoService.Update(photoEntity);
                        }
                        dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "null";
                        _service.Update(dtoForUpdate);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        await _photoService.ChangeNameFile(model.OldPhotoName, dtoForUpdate.Name, uploadsFolder);
                        var photoEntity = _photoService.GetEntity<PhotoDtoUpdate>(dtoForUpdate.PhotoId);
                        if (photoEntity != null)
                        {
                            photoEntity.UpdatedByUser = User.Identity?.Name ?? "null";
                            photoEntity.FileName = dtoForUpdate.Name;
                            _photoService.Update(photoEntity);
                        }
                        dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "null";
                        _service.Update(dtoForUpdate);
                    }
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                    await _photoService.DeletePhotoAsync(model.DtoForUpdate.Name, uploadsFolder);
                }
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromForm(Name = "Entity")] int id)
        {
            try
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "uploads", "estate_types");
                var entity = _service.GetWithId(id);
                if (entity == null)
                {
                    throw new Exception("The estate type is not found");
                }
                _service.Delete(id);
                await _photoService.DeletePhotoAsync(entity.Name, uploadsFolder);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangeShowCase([FromForm(Name = "EntityId")] int id)
        {
            try
            {
                var entity = _service.GetEntity<EstateTypesDtoForUpdate>(id);
                if (entity == null)
                {
                    throw new Exception("The estate type is not found");
                }
                entity.ShowCase = !entity.ShowCase;
                _service.Update(entity);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
