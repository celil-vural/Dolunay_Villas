using Entity.Dtos.BedTypes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models
{
    public class BedTypesUpdateModel
    {
        public SelectList? ItemTypeOptions { get; set; }
        public SelectList? ValueTypeOptions { get; set; }

        public BedTypesDtoForUpdate BedTypesDtoForUpdate { get; set; } = new();
    }
}
