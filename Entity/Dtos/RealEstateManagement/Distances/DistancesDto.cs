namespace Entity.Dtos.RealEstateManagement.Distances
{
    public record DistancesDto
    {
        public int Id { get; set; }
        public string Title_Tr { get; set; } = string.Empty;
        public string Title_En { get; set; } = string.Empty;
        public string? FontAwesomeIcon { get; set; } = string.Empty;
        public int? LocalIconId { get; set; }
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
    }
}
