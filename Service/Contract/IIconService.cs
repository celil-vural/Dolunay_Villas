using Entity.Dtos.Icon;
using Entity.Models;
using Microsoft.AspNetCore.Http;

namespace Service.Contract
{
    public interface IIconService : IBaseService<Icon, IconDto>
    {
        Task ConvertPhotoAsync(IFormFile formFile, string fileName, string outputPath);
        Task<string[]> GetPhotoNamesAsync(string directory);
        Task DeletePhotoAsync(string fileName, string outputPath);
        Task ChangeNameFile(string oldFileName, string newFileName, string outputPath);
    }
}
