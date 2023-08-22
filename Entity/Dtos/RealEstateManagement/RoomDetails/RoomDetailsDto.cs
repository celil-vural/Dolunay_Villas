using Entity.Dtos.RealEstateManagement.RealEstate;
using Entity.Dtos.RealEstateManagement.Rooms;

namespace Entity.Dtos.RealEstateManagement.RoomDetails
{
    public record RoomDetailsDto
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
        public RoomsDto Room { get; set; } = new();
        public RealEstateDto RealEstate { get; set; } = new();
    }
}
