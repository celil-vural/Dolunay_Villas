namespace Entity.Dtos.Villas
{
    public record VillaDtoForInsertion : VillaDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
