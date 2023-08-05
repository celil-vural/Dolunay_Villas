using Entity.Enums;

namespace Entity.RequestParameters
{
    public class VillaRequestParameters
    {
        public decimal MinPrice { get; set; } = 0;
        public decimal MaxPrice { get; set; } = decimal.MaxValue;
        public bool IsValidPriceRange => MaxPrice > MinPrice;
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public SortBy SortBy { get; set; } = SortBy.NameAsc;
        public VillaRequestParameters() : this(1, 10) { }
        public VillaRequestParameters(int pageNumber = 1, int pageSize = 10)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}