namespace Entity.Dtos.Villas
{
    public record VillaDtoForUpdate : VillaDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
