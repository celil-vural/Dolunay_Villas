using Entity.Models;
using Entity.RequestParameters;
using Repository.Concrete.EntityFramework;
using Repository.Contracts;
using Repository.Extensions;

namespace Repository.Concrete
{
    public class RealEstateRulesRepository : RepositoryBase<Rules>, IRealEstateRulesRepository
    {
        public RealEstateRulesRepository(RepositoryContext context) : base(context)
        {

        }

        public IEnumerable<Rules>? GetAllRulesWithDetials(RealEsateRequestParameters? parameters)
        {
            if (parameters == null)
            {
                return GetList();
            }
            return GetList()?.ToList().ToPaginatedList(parameters.PageNumber, parameters.PageSize);
        }

        public Rules? GetRuleWithId(int id)
        {
            return Get((r) => r.Id == id);
        }
    }
}
