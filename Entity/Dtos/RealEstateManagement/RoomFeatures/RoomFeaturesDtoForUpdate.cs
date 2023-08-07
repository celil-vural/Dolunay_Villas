namespace Entity.Dtos.RealEstateManagement.RoomFeatures
{
    public record RoomFeaturesDtoForUpdate : RoomFeaturesDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
