using Entity.Models;
using Entity.RequestParameters;
using Repository.Concrete.EntityFramework;
using Repository.Contracts;
using Repository.Extensions;

namespace Repository.Concrete
{
    public class RealEstateBedTypesRepository : RepositoryBase<BedTypes>, IRealEstateBedTypesRepository
    {
        public RealEstateBedTypesRepository(RepositoryContext context) : base(context)
        {
        }
        public IEnumerable<BedTypes>? GetAllWithDetails(PageRequestParameters? parameters)
        {
            if (parameters == null)
            {
                return GetList();
            }
            return GetList()?.ToList().ToPaginatedList(parameters.PageNumber, parameters.PageSize);
        }
    }
}
