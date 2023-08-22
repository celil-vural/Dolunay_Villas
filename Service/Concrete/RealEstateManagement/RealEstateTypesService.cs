using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.EstateTypes;
using Entity.Models.RealEstateManagement.EstateType;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.EstateTypes;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateTypesService : BaseService<EstateTypes, EstateTypesDto>, IRealEstateTypesService
    {
        public RealEstateTypesService(IRealEstateTypesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }

        [FluentValidationAspect(typeof(RealEstateTypesValidator))]
        public override void Update(EstateTypesDto dto)
        {
            base.Update(dto);
        }
        [FluentValidationAspect(typeof(RealEstateTypesValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
    }
}
