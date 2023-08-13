namespace Entity.Dtos.Icon
{
    public record IconDto
    {
        public int Id { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
    }
}
