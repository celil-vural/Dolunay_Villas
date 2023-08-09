namespace Entity.Dtos.RealEstateManagement.Region
{
    public record RegionDtoForInsertion : RegionDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
