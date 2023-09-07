using Entity.Models.RealEstateManagement.RoomsForAddVillas;

namespace Entity.Dtos.Villas
{
    public record VillaDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<RoomsForAddVilla> Rooms { get; set; } = new List<RoomsForAddVilla>();
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
    }
}
