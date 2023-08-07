using Entity.Models;
using Entity.RequestParameters;

namespace Repository.Contracts
{
    public interface IRealEstateBedTypesRepository : IRepositoryBase<BedTypes>
    {
        IEnumerable<BedTypes>? GetAllWithDetails(PageRequestParameters? parameters);

    }
}
