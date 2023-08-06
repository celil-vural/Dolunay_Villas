namespace Entity.Dtos.HeatingOptions
{
    public record HeatingOptionsDtoForInsertions : HeatingOptionsDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.Now;
        public DateTime UpdatedAt { get; init; } = DateTime.Now;
    }
}
