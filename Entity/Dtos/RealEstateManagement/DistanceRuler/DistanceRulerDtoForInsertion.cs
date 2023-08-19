namespace Entity.Dtos.RealEstateManagement.DistanceRuler
{
    public record DistanceRulerDtoForInsertion : DistanceRulerDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
