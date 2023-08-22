using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.ValueTypes;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.ValueTypes;
using ValueType = Entity.Models.RealEstateManagement.ValueType.ValueType;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateValueTypesService : BaseService<ValueType, ValueTypeDto>, IRealEstateValueTypesService
    {
        public RealEstateValueTypesService(IRealEstateValueTypesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
        [FluentValidationAspect(typeof(RealEstateValueTypesValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(RealEstateValueTypesValidator))]
        public override void Update(ValueTypeDto dto)
        {
            base.Update(dto);
        }
    }
}
