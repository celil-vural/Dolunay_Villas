using Entity.Dtos.RealEstateManagement.RoomDetails;

namespace Entity.Dtos.RealEstateManagement.RealEstate
{
    public record RoomDetailsDtoForInsertion : RoomDetailsDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
