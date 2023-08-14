namespace Entity.Dtos.RealEstateManagement.PropertyProperties
{
    public record PropertyPropertiesDtoForUpdate : PropertyPropertiesDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
