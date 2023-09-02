using Entity.Contracts;
using Entity.Models.RealEstateManagement.BedTypes;
using Entity.Models.RealEstateManagement.Room;
namespace Entity.Models.RealEstateManagement.RoomsForAddVillas
{
    public class RoomsForAddVilla : IEntity
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int BedTypeId { get; set; }
        public string BedTypeValue { get; set; } = string.Empty;
        public int VillaId { get; set; }
        public virtual Villa Villa { get; set; } = new();
        public virtual Rooms Room { get; set; } = new();
        public virtual BedType BedType { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
    }
}
