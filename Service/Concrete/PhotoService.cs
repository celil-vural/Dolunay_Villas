using AutoMapper;
using Entity.Dtos.Photo;
using Entity.Models;
using Microsoft.AspNetCore.Http;
using Repository.Contracts;
using Service.Contract;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Webp;

namespace Service.Concrete
{
    public class PhotoService : BaseService<Photo, PhotoDto>, IPhotoService
    {
        public PhotoService(IPhotoRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
        public async Task DeletePhotoAsync(string fileName, string outputPath)
        {
            var isExists = await IsPhotoNameExistsAsync(fileName, outputPath);
            if (!isExists)
            {
                throw new Exception("This file name does not exist.");
            }
            fileName = String.Concat(fileName, ".webp");
            string outputFileNameAndPath = Path.Combine(outputPath, fileName);
            File.Delete(outputFileNameAndPath);
        }
        public async Task ChangeNameFile(string oldFileName, string newFileName, string outputPath)
        {
            oldFileName = String.Concat(oldFileName, ".webp");
            newFileName = String.Concat(newFileName, ".webp");
            string oldFileNameAndPath = Path.Combine(outputPath, oldFileName);
            string newFileNameAndPath = Path.Combine(outputPath, newFileName);
            File.Move(oldFileNameAndPath, newFileNameAndPath);
        }
        public async Task ConvertPhotoAsync(IFormFile formFile, string fileName, string outputPath)
        {
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }
            var isExists = await IsPhotoNameExistsAsync(fileName, outputPath);
            if (isExists)
            {
                throw new Exception("This file name already exists.");
            }
            fileName = String.Concat(fileName, ".webp");
            string outputFileNameAndPath = Path.Combine(outputPath, fileName);
            using var image = Image.Load(formFile.OpenReadStream());
            IImageEncoder webpEncoder = new WebpEncoder();
            var memoryStream = new MemoryStream();
            image.Save(memoryStream, webpEncoder);
            var maxSizeInBytes = 500 * 1024;
            if (memoryStream.Length > maxSizeInBytes)
            {
                var quality = await CalculateOptimalQualityAsync(formFile, maxSizeInBytes);
                image.Save(outputFileNameAndPath, new WebpEncoder { Quality = quality });
            }
            else
            {
                image.Save(outputFileNameAndPath, webpEncoder);
            }
        }

        private static async Task<int> CalculateOptimalQualityAsync(IFormFile formFile, long targetSize)
        {
            int quality = 100;
            while (true)
            {
                using var image = Image.Load(formFile.OpenReadStream());
                var memoryStream = new MemoryStream();
                var webpEncoder = new WebpEncoder { Quality = quality };
                image.Save(memoryStream, webpEncoder);

                if (memoryStream.Length <= targetSize || quality == 5)
                {
                    break;
                }

                quality -= 5;
            }
            return quality;
        }

        private static async Task<bool> IsPhotoNameExistsAsync(string fileName, string outputPath)
        {
            var webpFileName = Path.Combine(outputPath, fileName + ".webp");
            return await Task.Run(() => File.Exists(webpFileName));
        }

        public async Task<string[]> GetPhotoNamesAsync(string directory)
        {
            try
            {
                string[] fileNames = await Task.Run(() => Directory.GetFiles(directory));
                return fileNames;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

