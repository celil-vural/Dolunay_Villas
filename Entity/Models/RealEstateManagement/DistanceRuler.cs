using Entity.Contracts;

namespace Entity.Models.RealEstateManagement
{
    public class DistanceRuler : IEntity
    {
        public int Id { get; set; }
        public string PlaceName { get; set; } = string.Empty;
        public int LocationTypeId { get; set; }
        public int RegionId { get; set; }
        public int DistanceId { get; set; }
        public string Coordinates { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public LocationType LocationType { get; set; } = new();
        public Region Region { get; set; } = new();
        public Distances Distance { get; set; } = new();
    }
}
