using Entity.Dtos.Photo;

namespace Entity.Dtos.RealEstateManagement.EstateTypes
{
    public record EstateTypesDto
    {
        public int Id { get; init; }
        public string Name { get; set; } = string.Empty;
        public int? ParentEstateTypesId { get; init; }
        public int PhotoId { get; set; }
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public bool ShowCase { get; set; }
        public EstateTypesDto? ParentEstateTypes { get; init; }
        public PhotoDto? Photo { get; init; }
        public ICollection<EstateTypesDto> SubEstateTypes { get; set; } = new HashSet<EstateTypesDto>();
    }
}
