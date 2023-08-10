using AutoMapper;
using Entity.Dtos.RealEstateManagement.Rules;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;

namespace Service.Concrete.RealEstateManagement
{

    public class RealEstateRulesService : BaseService<Rules, RulesDto>, IRealEstateRulesService
    {
        public RealEstateRulesService(IRealEstateRulesRepository realEstateRulesRepository, IMapper mapper) : base(realEstateRulesRepository, mapper)
        {
        }
    }
}
