namespace Entity.Dtos.RealEstateManagement.RoomFeatures
{
    public record RoomFeaturesDtoForInsertions : RoomFeaturesDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
