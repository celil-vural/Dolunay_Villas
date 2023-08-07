using AutoMapper;
using Entity.Dtos.BedTypes;
using Entity.Models;
using Entity.RequestParameters;
using Repository.Contracts;
using Service.Contract;

namespace Service.Concrete
{
    public class RealEstateBedTypesService : BaseService<BedTypes>, IRealEstateBedTypesService
    {
        private readonly IMapper _mapper;
        private readonly IRealEstateBedTypesRepository _baseRepository;
        public RealEstateBedTypesService(IRealEstateBedTypesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _mapper = mapper;
            _baseRepository = baseRepository;
        }
        public IEnumerable<BedTypesDto>? GetWithDetail(PageRequestParameters? parameters)
        {
            var entity = _baseRepository.GetAllWithDetails(parameters);
            var dto = _mapper.Map<IEnumerable<BedTypesDto>>(entity);
            return dto;
        }
    }
}
