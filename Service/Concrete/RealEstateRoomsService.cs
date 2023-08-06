using AutoMapper;
using Entity.Dtos.Rooms;
using Entity.Models;
using Entity.RequestParameters;
using Repository.Contracts;
using Service.Contract;

namespace Service.Concrete
{
    public class RealEstateRoomsService : BaseService<Rooms>, IRealEstateRoomsService
    {
        private readonly IMapper _mapper;
        private readonly IRealEstateRoomsRepository _realEstateRoomsRepository;

        public RealEstateRoomsService(IRealEstateRoomsRepository realEstateRoomsRepository, IMapper mapper) : base(realEstateRoomsRepository, mapper)
        {
            _realEstateRoomsRepository = realEstateRoomsRepository;
            _mapper = mapper;
        }
        public IEnumerable<RoomsDto>? GetAllWithDetails(PageRequestParameters? parameters)
        {
            var entity = _realEstateRoomsRepository.GetAllWithDetails(parameters);
            var dto = _mapper.Map<IEnumerable<RoomsDto>>(entity);
            return dto;
        }
    }
}
