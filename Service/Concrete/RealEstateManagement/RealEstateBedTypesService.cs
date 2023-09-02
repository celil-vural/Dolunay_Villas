using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.BedTypes;
using Entity.Models.RealEstateManagement.BedTypes;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.BedTypesRules;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateBedTypesService : BaseService<BedType, BedTypesDto>, IRealEstateBedTypesService
    {
        public RealEstateBedTypesService(IRealEstateBedTypesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        { }
        [FluentValidationAspect(typeof(RealEstateBedTypesValidator))]
        public override void Update(BedTypesDto dto)
        {
            base.Update(dto);
        }
        [FluentValidationAspect(typeof(RealEstateBedTypesValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
    }
}
