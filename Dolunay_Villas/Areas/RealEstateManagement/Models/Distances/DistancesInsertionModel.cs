using Entity.Dtos.Icon;
using Entity.Dtos.RealEstateManagement.Distances;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models.Distances
{
    public class DistancesInsertionModel
    {
        public DistancesDtoForInsertion DtoForInsertion { get; set; } = new();
        public IEnumerable<IconDto>? LocalIcons { get; set; } = new HashSet<IconDto>();
        public HashSet<string>? FontAwesomeIcons { get; set; } = new();
    }
}
