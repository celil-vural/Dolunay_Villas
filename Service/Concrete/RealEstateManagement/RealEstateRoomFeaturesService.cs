using AutoMapper;
using Entity.Dtos.RealEstateManagement.RoomFeatures;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateRoomFeaturesService : BaseService<RoomFeatures, RoomFeaturesDto>, IRealEstateRoomFeaturesService
    {
        public RealEstateRoomFeaturesService(IMapper mapper, IRealEstateRoomFeaturesRepository realEstateRoomFeaturesRepository) : base(realEstateRoomFeaturesRepository, mapper)
        {
        }
    }
}
