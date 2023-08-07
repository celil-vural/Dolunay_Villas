namespace Entity.Dtos.RealEstateManagement.Highlights
{
    public record HighlightsDtoForInsertions : HighlightsDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
