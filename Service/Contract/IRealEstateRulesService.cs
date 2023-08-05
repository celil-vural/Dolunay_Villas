using Entity.Dtos.Rules;
using Entity.RequestParameters;

namespace Service.Contract
{
    public interface IRealEstateRulesService
    {
        IEnumerable<RulesDto>? GetRules();
        IEnumerable<RulesDto>? GetRulesWithDetail(RealEsateRequestParameters? parameters);
        RulesDtoForUpdate? GetRule(int id);
        void UpdateRules(RulesDto rulesDto);
        void CreateRules(RulesDtoForInsertion rulesDto);
        void DeleteRules(int id);
    }
}
