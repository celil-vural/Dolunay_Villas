using Entity.Contracts;
namespace Entity.Models.RealEstateManagement.BedTypes
{
    public class BedType : IEntity
    {
        public int Id { get; set; }
        public string Title_Tr { get; set; } = string.Empty;
        public string Title_En { get; set; } = string.Empty;
        public string? FontAwesomeIcon { get; set; } = string.Empty;
        public int? LocalIconId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public int ItemTypeId { get; set; }
        public int ValueTypeId { get; set; }
        public virtual ItemType.ItemType ItemType { get; set; } = new();
        public virtual Entity.Models.RealEstateManagement.ValueType.ValueType ValueType { get; set; } = new();
    }
}
