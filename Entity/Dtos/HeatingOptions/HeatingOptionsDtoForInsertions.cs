namespace Entity.Dtos.HeatingOptions
{
    public record HeatingOptionsDtoForInsertions : HeatingOptionsDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
