namespace Entity.Dtos.RealEstateManagement.Distances
{
    public record DistancesDtoForUpdate : DistancesDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
