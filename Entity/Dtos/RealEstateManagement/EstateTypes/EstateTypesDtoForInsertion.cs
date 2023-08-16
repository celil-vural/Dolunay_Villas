namespace Entity.Dtos.RealEstateManagement.EstateTypes
{
    public record EstateTypesDtoForInsertion : EstateTypesDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
