using Entity.Dtos.Photo;

namespace Dolunay_Villas.Areas.Admin.Models
{
    public class PhotoUpdateModel
    {
        public PhotoDtoUpdate PhotoDtoUpdate { get; set; } = new();
        public string OldFileName { get; set; } = string.Empty;
    }
}
