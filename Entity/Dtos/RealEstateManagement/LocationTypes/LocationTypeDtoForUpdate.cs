namespace Entity.Dtos.RealEstateManagement.LocationTypes
{
    public record LocationTypeDtoForUpdate : LocationTypeDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
