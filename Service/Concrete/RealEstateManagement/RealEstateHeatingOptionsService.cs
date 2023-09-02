using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.HeatingOptions;
using Entity.Models.RealEstateManagement.HeatingOptions;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.HeatingOptions;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateHeatingOptionsService : BaseService<HeatingOption, HeatingOptionsDto>, IRealEstateHeatingOptionsService
    {
        public RealEstateHeatingOptionsService(IRealEstateHeatingOptionsRepository realEstateHeatingOptionsRepository, IMapper mapper) : base(realEstateHeatingOptionsRepository, mapper) { }
        [FluentValidationAspect(typeof(RealEstateHeatingOptionsValidatior))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(RealEstateHeatingOptionsValidatior))]
        public override void Update(HeatingOptionsDto dto)
        {
            base.Update(dto);
        }
    }
}
