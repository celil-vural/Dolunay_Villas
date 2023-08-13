using Entity.Dtos.Photo;

namespace Dolunay_Villas.Areas.Admin.Models.Photo
{
    public class PhotoUpdateModel
    {
        public PhotoDtoUpdate PhotoDtoUpdate { get; set; } = new();
        public string OldFileName { get; set; } = string.Empty;
    }
}
