namespace Entity.Dtos.RoomFeatures
{
    public record RoomFeaturesDtoForInsertions : RoomFeaturesDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.Now;
        public DateTime? UpdatedAt { get; init; } = DateTime.Now;
    }
}
