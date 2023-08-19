namespace Entity.Dtos.RealEstateManagement.DistanceRuler
{
    public record DistanceRulerDtoForUpdate : DistanceRulerDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
