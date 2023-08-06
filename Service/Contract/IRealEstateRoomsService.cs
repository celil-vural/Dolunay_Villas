using Entity.Dtos.Rooms;
using Entity.Models;
using Entity.RequestParameters;

namespace Service.Contract
{
    public interface IRealEstateRoomsService : IBaseService<Rooms>
    {
        IEnumerable<RoomsDto>? GetAllWithDetails(PageRequestParameters? parameters);
    }
}
