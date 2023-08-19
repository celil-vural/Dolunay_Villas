using Entity.Contracts;

namespace Entity.Models.RealEstateManagement
{
    public class LocationType : IEntity
    {
        public int Id { get; set; }
        public string LocationTypeName { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
