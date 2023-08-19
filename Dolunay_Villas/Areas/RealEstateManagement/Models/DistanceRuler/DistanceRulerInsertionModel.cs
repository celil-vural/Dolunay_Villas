using Entity.Dtos.RealEstateManagement.DistanceRuler;
using Entity.Dtos.RealEstateManagement.Distances;
using Entity.Dtos.RealEstateManagement.LocationTypes;
using Entity.Dtos.RealEstateManagement.Region;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models.DistanceRuler
{
    public class DistanceRulerInsertionModel
    {
        public DistanceRulerDtoForInsertion DtoInsertion { get; set; } = new();
        public IEnumerable<DistancesDto> Distances { get; set; } = new HashSet<DistancesDto>();
        public IEnumerable<RegionDto> Regions { get; set; } = new HashSet<RegionDto>();
        public IEnumerable<LocationTypeDto> LocationTypes { get; set; } = new HashSet<LocationTypeDto>();
    }
}
