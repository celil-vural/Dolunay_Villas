namespace Entity.Dtos.RealEstateManagement.RealEstateFeatures
{
    public record RealEstateFeaturesDtoForUpdate : RealEstateFeaturesDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
