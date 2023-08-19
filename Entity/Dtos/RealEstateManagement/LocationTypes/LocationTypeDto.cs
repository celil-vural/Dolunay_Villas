namespace Entity.Dtos.RealEstateManagement.LocationTypes
{
    public record LocationTypeDto
    {
        public int Id { get; set; }
        public string LocationTypeName { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
    }
}
