namespace Entity.Dtos.RealEstateManagement.Rule
{
    public record RulesDto
    {
        public int Id { get; init; }
        public string Title_Tr { get; set; } = string.Empty;
        public string Title_En { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public string? FontAwesomeIcon { get; set; }
        public int? LocalIconId { get; set; }
    }
}
