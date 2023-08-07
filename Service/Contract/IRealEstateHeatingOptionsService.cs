using Entity.Dtos.HeatingOptions;
using Entity.Models;
using Entity.RequestParameters;

namespace Service.Contract
{
    public interface IRealEstateHeatingOptionsService : IBaseService<HeatingOptions>
    {
        IEnumerable<HeatingOptionsDto>? GetWithDetail(PageRequestParameters? parameters);
    }
}
