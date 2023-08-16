using Entity.Dtos.RealEstateManagement.EstateTypes;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models.EstateTypes
{
    public class EstateTypesInsertionModel
    {
        public EstateTypesDtoForInsertion DtoForInsertion { get; set; } = new();
        public IFormFile? Photo { get; set; }
    }
}
