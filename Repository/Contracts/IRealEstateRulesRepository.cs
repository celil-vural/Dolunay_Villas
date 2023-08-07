using Entity.Models;
using Entity.RequestParameters;

namespace Repository.Contracts
{
    public interface IRealEstateRulesRepository : IRepositoryBase<Rules>
    {
        IEnumerable<Rules>? GetAllRulesWithDetials(PageRequestParameters? parameters);
    }
}
