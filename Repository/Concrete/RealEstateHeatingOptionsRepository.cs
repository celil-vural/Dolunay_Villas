using Entity.Models;
using Entity.RequestParameters;
using Repository.Concrete.EntityFramework;
using Repository.Contracts;
using Repository.Extensions;

namespace Repository.Concrete
{
    public class RealEstateHeatingOptionsRepository : RepositoryBase<HeatingOptions>, IRealEstateHeatingOptionsRepository
    {
        public RealEstateHeatingOptionsRepository(RepositoryContext context) : base(context)
        {
        }
        public IEnumerable<HeatingOptions>? GetAllWithDetails(PageRequestParameters? parameters)
        {
            if (parameters == null)
            {
                return GetList();
            }
            return GetList()?.ToList().ToPaginatedList(parameters.PageNumber, parameters.PageSize);
        }
    }
}
