namespace Entity.Dtos.RealEstateManagement.Distances
{
    public record DistancesDtoForInsertion : DistancesDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
