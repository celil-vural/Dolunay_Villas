using Entity.Dtos.Icon;
using Entity.Dtos.RealEstateManagement.Distances;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models.Distances
{
    public class DistancesUpdateModel
    {
        public DistancesDtoForUpdate DtoForUpdate { get; set; } = new();
        public IEnumerable<IconDto>? LocalIcons { get; set; }
        public HashSet<string>? FontAwesomeIcons { get; set; }
    }
}
