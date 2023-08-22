using Entity.Contracts;

namespace Entity.Models.RealEstateManagement.EstateType
{
    public class EstateTypes : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? ParentEstateTypesId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public int? PhotoId { get; set; }
        public bool ShowCase { get; set; }
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public EstateTypes? ParentEstateTypes { get; set; }
        public Photo? Photo { get; set; } = new();
        public ICollection<EstateTypes> SubEstateTypes { get; set; } = new HashSet<EstateTypes>();
    }
}
