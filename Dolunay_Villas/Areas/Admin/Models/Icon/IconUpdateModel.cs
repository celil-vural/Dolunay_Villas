using Entity.Dtos.Icon;

namespace Dolunay_Villas.Areas.Admin.Models.Icon
{
    public class IconUpdateModel
    {
        public IconDtoForUpdate IconDtoForUpdate { get; set; } = new();
        public string OldFileName { get; set; } = string.Empty;
    }
}
