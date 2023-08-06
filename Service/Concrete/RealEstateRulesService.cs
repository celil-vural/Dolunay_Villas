using AutoMapper;
using Entity.Dtos.Rules;
using Entity.Models;
using Entity.RequestParameters;
using Repository.Contracts;
using Service.Contract;

namespace Service.Concrete
{
    public class RealEstateRulesService : BaseService<Rules>, IRealEstateRulesService
    {
        private readonly IRealEstateRulesRepository _realEstateRulesRepository;
        private readonly IMapper _mapper;
        public RealEstateRulesService(IRealEstateRulesRepository realEstateRulesRepository, IMapper mapper) : base(realEstateRulesRepository, mapper)
        {
            _realEstateRulesRepository = realEstateRulesRepository;
            _mapper = mapper;
        }
        public IEnumerable<RulesDto>? GetRulesWithDetail(PageRequestParameters? parameters)
        {
            var rules = _realEstateRulesRepository.GetAllRulesWithDetials(parameters);
            var rulesDto = _mapper.Map<IEnumerable<RulesDto>>(rules);
            return rulesDto;
        }
    }
}
