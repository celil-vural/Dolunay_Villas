using Entity.Models;
using Entity.RequestParameters;

namespace Repository.Contracts
{
    public interface IRealEstateRoomFeaturesRepository : IRepositoryBase<RoomFeatures>
    {
        IEnumerable<RoomFeatures>? GetAllRoomFeaturesWithDetails(PageRequestParameters? parameters);
        RoomFeatures? GetRoomFeatureWithId(int id);
    }
}
