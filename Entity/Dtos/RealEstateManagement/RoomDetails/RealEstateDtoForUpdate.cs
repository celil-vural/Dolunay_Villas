namespace Entity.Dtos.RealEstateManagement.RoomDetails
{
    public record RealEstateDtoForUpdate
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
