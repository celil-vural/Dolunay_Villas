using Entity.Dtos.Icon;
using Entity.Models;
using Microsoft.AspNetCore.Http;

namespace Service.Contract
{
    public interface IIconService : IBaseService<Icon, IconDto>
    {
        Task ConvertIconAsync(IFormFile formFile, string fileName, string outputPath);
        Task<string[]> GetIconNamesAsync(string directory);
        Task DeleteIconAsync(string fileName, string outputPath);
        Task ChangeNameFile(string oldFileName, string newFileName, string outputPath);
    }
}
