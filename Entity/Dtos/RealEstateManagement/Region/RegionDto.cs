namespace Entity.Dtos.RealEstateManagement.Region
{
    public record RegionDto
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public int? ParentRegionID { get; init; }
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public virtual RegionDto? ParentRegion { get; init; }
        public virtual ICollection<RegionDto> SubRegions { get; init; } = new HashSet<RegionDto>();
    }
}
