namespace Entity.Dtos.HeatingOptions
{
    public record HeatingOptionsDto
    {
        public int Id { get; init; }
        public string Heating_Options_Title_Tr { get; set; } = string.Empty;
        public string Heating_Options_Title_En { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
    }
}
