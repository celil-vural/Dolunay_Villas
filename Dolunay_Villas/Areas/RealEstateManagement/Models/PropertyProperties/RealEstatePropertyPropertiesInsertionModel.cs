using Entity.Dtos.Icon;
using Entity.Dtos.RealEstateManagement.PropertyProperties;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models.PropertyProperties
{
    public class RealEstatePropertyPropertiesInsertionModel
    {
        public PropertyPropertiesDtoForInsertion DtoForInsertion { get; set; } = new();
        public IEnumerable<IconDto>? LocalIcons { get; set; } = new HashSet<IconDto>();
        public HashSet<string>? FontAwesomeIcons { get; set; } = new();
    }
}
