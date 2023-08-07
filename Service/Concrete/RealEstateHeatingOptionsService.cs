using AutoMapper;
using Entity.Dtos.HeatingOptions;
using Entity.Models;
using Entity.RequestParameters;
using Repository.Contracts;
using Service.Contract;

namespace Service.Concrete
{
    public class RealEstateHeatingOptionsService : BaseService<HeatingOptions>, IRealEstateHeatingOptionsService
    {
        private readonly IMapper _mapper;
        private readonly IRealEstateHeatingOptionsRepository _realEstateHeatingOptionsRepository;

        public RealEstateHeatingOptionsService(IRealEstateHeatingOptionsRepository realEstateHeatingOptionsRepository, IMapper mapper) : base(realEstateHeatingOptionsRepository, mapper)
        {
            _realEstateHeatingOptionsRepository = realEstateHeatingOptionsRepository;
            _mapper = mapper;
        }


        public IEnumerable<HeatingOptionsDto>? GetWithDetail(PageRequestParameters? parameters)
        {
            var entity = _realEstateHeatingOptionsRepository.GetAllWithDetails(parameters);
            var dto = _mapper.Map<IEnumerable<HeatingOptionsDto>>(entity);
            return dto;
        }
    }
}
