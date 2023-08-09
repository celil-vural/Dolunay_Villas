using Dolunay_Villas.Models;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models
{
    public class BaseListViewModel<TDto>
    {
        public List<TDto>? Entities { get; set; } = new List<TDto>();
        public Pagination Pagination { get; set; } = new();
        public int TotalCount => Entities?.Count ?? 0;
    }
}
