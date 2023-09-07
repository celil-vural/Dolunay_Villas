using Entity.Dtos.RealEstateManagement.RealEstate;
using Entity.Dtos.Villas;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models.CreateRealEstate
{
    public class CreateRealEstateInsertionModel
    {
        public VillaDto VillaDto { get; set; }
        public RealEstateDto RealEstateDto { get; set; }
    }
}
