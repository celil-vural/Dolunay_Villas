using Entity.Dtos.Icon;
using Entity.Dtos.RealEstateManagement.BedTypes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models.BedTypes
{
    public class BedTypesUpdateModel
    {
        public SelectList? ItemTypeOptions { get; set; }
        public SelectList? ValueTypeOptions { get; set; }
        public BedTypesDtoForUpdate BedTypesDtoForUpdate { get; set; } = new();
        public IEnumerable<IconDto>? LocalIcons { get; set; }
        public HashSet<string>? FontAwesomeIcons { get; set; }
    }
}
