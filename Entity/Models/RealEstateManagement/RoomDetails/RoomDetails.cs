using Entity.Contracts;
using Entity.Models.RealEstateManagement.RealEstates;
using Entity.Models.RealEstateManagement.Room;

namespace Entity.Models.RealEstateManagement.RoomDetails
{
    public class RoomDetails : IEntity
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int RealEstateId { get; set; }
        public short JakuziCount { get; set; }
        public bool Sauna { get; set; }
        public short BathroomAndWC { get; set; }
        public bool Tv { get; set; }
        public short Commode { get; set; }
        public bool Wardrobe { get; set; }
        public bool MakeUpDesk { get; set; }
        public bool AirConditioning { get; set; }
        public short SingleBedCount { get; set; }
        public short DoubleBedCount { get; set; }
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public Rooms Room { get; set; } = new();
        public RealEstate RealEstate { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }
}
