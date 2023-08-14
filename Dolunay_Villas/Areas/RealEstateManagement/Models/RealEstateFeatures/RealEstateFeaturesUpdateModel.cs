using Entity.Dtos.Icon;
using Entity.Dtos.RealEstateManagement.RealEstateFeatures;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models.RealEstateFeatures
{
    public class RealEstateFeaturesUpdateModel
    {
        public RealEstateFeaturesDtoForUpdate DtoForUpdate { get; set; } = new();
        public IEnumerable<IconDto>? LocalIcons { get; set; } = new HashSet<IconDto>();
        public HashSet<string>? FontAwesomeIcons { get; set; } = new();
    }
}
