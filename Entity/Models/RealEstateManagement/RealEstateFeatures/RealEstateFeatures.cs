﻿using Entity.Contracts;

namespace Entity.Models.RealEstateManagement.RealEstateFeatures
{
    public class RealEstateFeatures : IEntity
    {
        public int Id { get; set; }
        public string Title_Tr { get; set; } = string.Empty;
        public string Title_En { get; set; } = string.Empty;
        public string? FontAwesomeIcon { get; set; } = string.Empty;
        public int? LocalIconId { get; set; }
        public int? ParentRealEstateFeaturesId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public RealEstateFeatures? ParentRealEstateFeatures { get; set; }
        public ICollection<RealEstateFeatures> SubRealEstateFeatures { get; set; } = new HashSet<RealEstateFeatures>();
    }
}
