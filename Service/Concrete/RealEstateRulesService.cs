using AutoMapper;
using Entity.Dtos.Rules;
using Entity.Models;
using Entity.RequestParameters;
using Repository.Contracts;
using Service.Contract;

namespace Service.Concrete
{
    public class RealEstateRulesService : IRealEstateRulesService
    {
        private readonly IRealEstateRulesRepository _realEstateRulesRepository;
        private readonly IMapper _mapper;

        public RealEstateRulesService(IRealEstateRulesRepository realEstateRulesRepository, IMapper mapper)
        {
            _realEstateRulesRepository = realEstateRulesRepository;
            _mapper = mapper;
        }

        public void CreateRules(RulesDtoForInsertion rulesDto)
        {
            Rules entity = _mapper.Map<Rules>(rulesDto);
            _realEstateRulesRepository.Add(entity);
        }

        public void DeleteRules(int id)
        {
            var rule = _realEstateRulesRepository.Get((r) => r.Id == id);
            if (rule == null)
                throw new Exception("Rule not found");
            _realEstateRulesRepository.Delete(rule);
        }

        public RulesDtoForUpdate? GetRule(int id)
        {
            var rule = _realEstateRulesRepository.Get((r) => r.Id == id);
            var ruleDto = _mapper.Map<RulesDtoForUpdate>(rule);
            return ruleDto;
        }

        public IEnumerable<RulesDto>? GetRules()
        {
            var rules = _realEstateRulesRepository.GetList();
            var rulesDto = _mapper.Map<IEnumerable<RulesDto>>(rules);
            return rulesDto;
        }

        public IEnumerable<RulesDto>? GetRulesWithDetail(RealEsateRequestParameters? parameters)
        {
            var rules = _realEstateRulesRepository.GetAllRulesWithDetials(parameters);
            var rulesDto = _mapper.Map<IEnumerable<RulesDto>>(rules);
            return rulesDto;
        }
        public void UpdateRules(RulesDto rulesDto)
        {
            var entity = _mapper.Map<Rules>(rulesDto);
            if (entity == null)
            {
                throw new Exception("Rule not found");
            }
            _realEstateRulesRepository.Update(entity);
        }
    }
}
