﻿using Entity.Contracts;

namespace Entity.Models
{
    public class HeatingOptions : IEntity
    {
        public int Id { get; set; }
        public string Heating_Options_Title_Tr { get; set; } = string.Empty;
        public string Heating_Options_Title_En { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
    }
}
