namespace Entity.Dtos.RealEstateManagement.LocationTypes
{
    public record LocationTypeDtoForInsertion : LocationTypeDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
