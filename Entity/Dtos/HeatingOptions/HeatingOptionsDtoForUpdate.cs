namespace Entity.Dtos.HeatingOptions
{
    public record HeatingOptionsDtoForUpdate : HeatingOptionsDto
    {
        public DateTime? UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
