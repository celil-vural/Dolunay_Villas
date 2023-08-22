using Entity.Dtos.RealEstateManagement.RealEstate;

namespace Entity.Dtos.RealEstateManagement.RoomDetails
{
    public record RealEstateDtoForInsertion : RealEstateDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
