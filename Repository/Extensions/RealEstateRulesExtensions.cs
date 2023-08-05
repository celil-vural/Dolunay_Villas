using Entity.Models;

namespace Repository.Extensions
{
    public static class RealEstateRulesExtensions
    {
        public static IEnumerable<Rules> ToPaginatedList(this List<Rules>? rules, int? pageNumber, int? pageSize)
        {
            pageNumber ??= 1;
            pageSize ??= 20;
            return rules.Skip((int)((pageNumber - 1) * pageSize)).Take((int)pageSize).ToList();
        }
    }
}
