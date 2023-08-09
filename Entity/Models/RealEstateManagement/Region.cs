using Entity.Contracts;
namespace Entity.Models.RealEstateManagement
{
    public class Region : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? ParentRegionID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public Region? ParentRegion { get; set; }
        public ICollection<Region> SubRegions { get; set; } = new HashSet<Region>();
    }
}