namespace Entity.Dtos.Icon
{
    public record IconDtoForInsertion : IconDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
