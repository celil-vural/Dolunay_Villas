using Entity.Dtos.RealEstateManagement.BedTypes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models
{
    public class BedTypesInsertionModel
    {
        public BedTypesDtoForInsertion BedTypesDtoForInsertion { get; set; } = new();
        public SelectList? ItemTypeOptions { get; set; }
        public SelectList? ValueTypeOptions { get; set; }
    }
}
