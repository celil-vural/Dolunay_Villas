namespace Entity.Dtos.RoomFeatures
{
    public record RoomFeaturesDto
    {
        public int Id { get; init; }
        public string Room_Features_Title_Tr { get; set; } = string.Empty;
        public string Room_Features_Title_En { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
    }
}
