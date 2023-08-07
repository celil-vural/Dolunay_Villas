namespace Entity.Dtos.RealEstateManagement.Highlights
{
    public record HighlightsDtoForUpdate : HighlightsDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
