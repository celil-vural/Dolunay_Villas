﻿namespace Entity.Dtos.RealEstateManagement.BedTypes
{
    public record BedTypesDtoForUpdate : BedTypesDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
