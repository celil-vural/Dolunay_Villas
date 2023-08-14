namespace Entity.Dtos.RealEstateManagement.PropertyProperties
{
    public record PropertyPropertiesDtoForInsertion : PropertyPropertiesDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
