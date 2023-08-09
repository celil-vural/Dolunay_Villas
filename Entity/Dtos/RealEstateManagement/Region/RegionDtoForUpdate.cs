namespace Entity.Dtos.RealEstateManagement.Region
{
    public record RegionDtoForUpdate : RegionDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
