using Entity.Dtos.Icon;
using Entity.Dtos.RealEstateManagement.RealEstateFeatures;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models.RealEstateFeatures
{
    public class RealEstateFeaturesInsertionModel
    {
        public RealEstateFeaturesDtoForInsertion DtoForInsertion { get; set; } = new();
        public IEnumerable<IconDto>? LocalIcons { get; set; } = new HashSet<IconDto>();
        public HashSet<string>? FontAwesomeIcons { get; set; } = new();
    }
}
