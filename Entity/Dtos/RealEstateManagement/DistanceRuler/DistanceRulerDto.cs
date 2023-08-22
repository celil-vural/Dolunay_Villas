using Entity.Dtos.RealEstateManagement.Distances;
using Entity.Dtos.RealEstateManagement.Region;
using Entity.Models.RealEstateManagement.LocationType;

namespace Entity.Dtos.RealEstateManagement.DistanceRuler
{
    public record DistanceRulerDto
    {
        public int Id { get; set; }
        public string PlaceName { get; set; } = string.Empty;
        public int LocationTypeId { get; set; }
        public int RegionId { get; set; }
        public int DistanceId { get; set; }
        public string Coordinates { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public LocationType LocationType { get; set; } = new();
        public RegionDto Region { get; set; } = new();
        public DistancesDto Distance { get; set; } = new();
    }
}
