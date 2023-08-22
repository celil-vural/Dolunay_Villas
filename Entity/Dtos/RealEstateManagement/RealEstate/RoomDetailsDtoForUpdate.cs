using Entity.Dtos.RealEstateManagement.RoomDetails;

namespace Entity.Dtos.RealEstateManagement.RealEstate
{
    public record RoomDetailsDtoForUpdate : RoomDetailsDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
