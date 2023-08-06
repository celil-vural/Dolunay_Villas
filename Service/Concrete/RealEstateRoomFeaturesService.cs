using AutoMapper;
using Entity.Dtos.RoomFeatures;
using Entity.Models;
using Entity.RequestParameters;
using Repository.Contracts;
using Service.Contract;

namespace Service.Concrete
{
    public class RealEstateRoomFeaturesService : BaseService<RoomFeatures>, IRealEstateRoomFeaturesService
    {
        private readonly IMapper _mapper;
        private readonly IRealEstateRoomFeaturesRepository _realEstateRoomFeaturesRepository;
        public RealEstateRoomFeaturesService(IMapper mapper, IRealEstateRoomFeaturesRepository realEstateRoomFeaturesRepository) : base(realEstateRoomFeaturesRepository, mapper)
        {
            _mapper = mapper;
            _realEstateRoomFeaturesRepository = realEstateRoomFeaturesRepository;
        }

        public IEnumerable<RoomFeaturesDto>? GetRoomFeaturesWithDetail(PageRequestParameters? parameters)
        {
            var entity = _realEstateRoomFeaturesRepository.GetAllRoomFeaturesWithDetails(parameters);
            var dto = _mapper.Map<IEnumerable<RoomFeaturesDto>>(entity);
            return dto;
        }
    }
}
