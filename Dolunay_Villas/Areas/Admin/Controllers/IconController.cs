using Entity.Dtos.Photo;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace Dolunay_Villas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IconController : Controller
    {
        private readonly IPhotoService _photoService;

        public IconController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        public IActionResult Index()
        {
            return View();
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

                    if (formFile != null && formFile.Length > 0)
                    {
                        if (formFile.Length <= 3 * 1024 * 1024) // 3 MB sınırlama
                        {
                            var fileName = Path.GetFileName(model.FileName);
                            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "uploads");
                            var filePath = Path.Combine(uploadsFolder, fileName);
                            using (var fileStream = new FileStream(filePath, FileMode.Create))
                            {
                                await formFile.CopyToAsync(fileStream);
                            }
                            model.CreatedByUser = User.Identity?.Name ?? "null";
                            _photoService.CreateWithDto(model);
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("Photo", "The photo size should be less than 3 MB.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View(model);
        }
    }
}
