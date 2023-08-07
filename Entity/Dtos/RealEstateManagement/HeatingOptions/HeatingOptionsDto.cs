namespace Entity.Dtos.RealEstateManagement.HeatingOptions
{
    public record HeatingOptionsDto
    {
        public int Id { get; init; }
        public string Title_Tr { get; set; } = string.Empty;
        public string Title_En { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
    }
}
