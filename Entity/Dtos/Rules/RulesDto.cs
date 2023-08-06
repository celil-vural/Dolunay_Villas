namespace Entity.Dtos.Rules
{
    public record RulesDto
    {
        public int Id { get; set; }
        public string Rule_Title_Tr { get; set; } = string.Empty;
        public string Rule_Title_En { get; set; } = string.Empty;
        public string IconString { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
    }
}
