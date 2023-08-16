namespace Entity.Dtos.RealEstateManagement.EstateTypes
{
    public record EstateTypesDtoForUpdate : EstateTypesDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
