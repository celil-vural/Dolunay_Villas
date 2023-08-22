namespace Entity.Dtos.RealEstateManagement.RealEstateFeatures
{
    public record RealEstateFeaturesDto
    {
        public int Id { get; init; }
        public string Title_Tr { get; set; } = string.Empty;
        public string Title_En { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public string? FontAwesomeIcon { get; set; }
        public int? LocalIconId { get; set; }
        public int? ParentRealEstateFeaturesId { get; init; }
        public virtual RealEstateFeaturesDto? ParentRealEstateFeatures { get; init; }
        public ICollection<RealEstateFeaturesDto> SubRealEstateFeatures { get; init; } = new HashSet<RealEstateFeaturesDto>();
    }
}
