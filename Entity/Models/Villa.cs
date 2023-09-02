using Entity.Contracts;
using Entity.Models.RealEstateManagement.RoomsForAddVillas;

namespace Entity.Models
{
    public class Villa : IEntity
    {
        public int Id { get; set; }
        public virtual ICollection<RoomsForAddVilla> Rooms { get; set; } = new List<RoomsForAddVilla>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
    }
}
