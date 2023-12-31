﻿using Entity.Contracts;

namespace Entity.Models.RealEstateManagement.Distance
{
    public class Distances : IEntity
    {
        public int Id { get; set; }
        public string Title_Tr { get; set; } = string.Empty;
        public string Title_En { get; set; } = string.Empty;
        public string? FontAwesomeIcon { get; set; } = string.Empty;
        public int? LocalIconId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public Icon LocalIcon { get; set; } = new();
    }
}
