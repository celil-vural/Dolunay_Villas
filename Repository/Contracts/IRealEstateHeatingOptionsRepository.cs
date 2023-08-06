using Entity.Models;
using Entity.RequestParameters;

namespace Repository.Contracts
{
    public interface IRealEstateHeatingOptionsRepository : IRepositoryBase<HeatingOptions>
    {
        IEnumerable<HeatingOptions>? GetAllHeatingOptionsWithDetails(PageRequestParameters? parameters);
        HeatingOptions? GetHeatingOptionWithId(int id);
    }
}
