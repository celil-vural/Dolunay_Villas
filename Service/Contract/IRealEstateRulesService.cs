using Entity.Dtos.Rules;
using Entity.Models;
using Entity.RequestParameters;

namespace Service.Contract
{
    public interface IRealEstateRulesService : IBaseService<Rules>
    {
        IEnumerable<RulesDto>? GetRulesWithDetail(PageRequestParameters? parameters);
    }
}
