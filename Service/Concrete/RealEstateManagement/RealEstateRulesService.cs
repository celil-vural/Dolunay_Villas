using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.Rule;
using Entity.Models.RealEstateManagement.Rule;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.Rules;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateRulesService : BaseService<Rules, RulesDto>, IRealEstateRulesService
    {
        public RealEstateRulesService(IRealEstateRulesRepository realEstateRulesRepository, IMapper mapper) : base(realEstateRulesRepository, mapper)
        {
        }

        [FluentValidationAspect(typeof(RealEstateRulesValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }

        [FluentValidationAspect(typeof(RealEstateRulesValidator))]
        public override void Update(RulesDto dto)
        {
            base.Update(dto);
        }
    }
}
