using Entity.Dtos.BedTypes;
using Entity.Models;
using Entity.RequestParameters;

namespace Service.Contract
{
    public interface IRealEstateBedTypesService : IBaseService<BedTypes>
    {
        IEnumerable<BedTypesDto>? GetWithDetail(PageRequestParameters? parameters);

    }
}
