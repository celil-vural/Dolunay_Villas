using Entity.Contracts;
using Entity.Models.RealEstateManagement.BedTypes;

namespace Entity.Models.RealEstateManagement.ItemType
{
    public class ItemType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public virtual ICollection<BedType>? BedTypes { get; set; }
    }
}
