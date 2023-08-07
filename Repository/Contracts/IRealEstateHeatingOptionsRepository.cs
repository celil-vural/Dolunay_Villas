using Entity.Models;
using Entity.RequestParameters;
namespace Repository.Contracts
{
    public interface IRealEstateHeatingOptionsRepository : IRepositoryBase<HeatingOptions>
    {
        IEnumerable<HeatingOptions>? GetAllWithDetails(PageRequestParameters? parameters);
    }
}