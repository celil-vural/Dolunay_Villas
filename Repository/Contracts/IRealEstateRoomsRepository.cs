using Entity.Models;
using Entity.RequestParameters;

namespace Repository.Contracts
{
    public interface IRealEstateRoomsRepository : IRepositoryBase<Rooms>
    {
        IEnumerable<Rooms>? GetAllWithDetails(PageRequestParameters? parameters);
        Rooms? GetRoomsWithId(int id);
    }
}
