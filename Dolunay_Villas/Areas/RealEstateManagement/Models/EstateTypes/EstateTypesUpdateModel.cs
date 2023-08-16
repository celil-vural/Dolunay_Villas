using Entity.Dtos.RealEstateManagement.EstateTypes;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models.EstateTypes
{
    public class EstateTypesUpdateModel
    {
        public EstateTypesDtoForUpdate DtoForUpdate { get; set; } = new();
        public string OldPhotoName { get; set; } = string.Empty;
        public IFormFile? Photo { get; set; }
    }
}
