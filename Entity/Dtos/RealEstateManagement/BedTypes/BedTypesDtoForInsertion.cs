namespace Entity.Dtos.RealEstateManagement.BedTypes
{
    public record BedTypesDtoForInsertion : BedTypesDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
