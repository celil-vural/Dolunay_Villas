using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.HeatingOptions;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.HeatingOptions;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateHeatingOptionsService : BaseService<HeatingOptions, HeatingOptionsDto>, IRealEstateHeatingOptionsService
    {
        public RealEstateHeatingOptionsService(IRealEstateHeatingOptionsRepository realEstateHeatingOptionsRepository, IMapper mapper) : base(realEstateHeatingOptionsRepository, mapper) { }
        [FluentValidationAspect(typeof(RealEstateHeatingOptionsInsertionValidation))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(RealEstateHeatingOptionsUpdateValidation))]
        public override void Update(HeatingOptionsDto dto)
        {
            base.Update(dto);
        }
    }
}
