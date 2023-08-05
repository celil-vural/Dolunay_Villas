using Dolunay_Villas.Models;
using Entity.Dtos.Rules;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models
{
    public class RealEstateRulesListViewModel
    {
        public List<RulesDto>? Rules { get; set; } = new List<RulesDto>();
        public Pagination Pagination { get; set; } = new();
        public int TotalCount => Rules.Count;
    }
}
