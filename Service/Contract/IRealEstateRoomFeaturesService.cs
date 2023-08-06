using Entity.Dtos.RoomFeatures;
using Entity.Models;
using Entity.RequestParameters;

namespace Service.Contract
{
    public interface IRealEstateRoomFeaturesService : IBaseService<RoomFeatures>
    {
        IEnumerable<RoomFeaturesDto>? GetRoomFeaturesWithDetail(PageRequestParameters? parameters);

    }
}
