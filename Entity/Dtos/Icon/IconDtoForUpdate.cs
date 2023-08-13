namespace Entity.Dtos.Icon
{
    public record IconDtoForUpdate : IconDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
