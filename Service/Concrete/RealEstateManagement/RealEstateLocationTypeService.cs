using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.LocationTypes;
using Entity.Models.RealEstateManagement.LocationType;
using Repository.Contracts;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.LocationTypes;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateLocationTypeService : BaseService<LocationType, LocationTypeDto>, IRealEstateLocationTypeService
    {
        public RealEstateLocationTypeService(IRepositoryBase<LocationType> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }

        [FluentValidationAspect(typeof(RealEstateLocationTypesValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }

        [FluentValidationAspect(typeof(RealEstateLocationTypesValidator))]
        public override void Update(LocationTypeDto dto)
        {
            base.Update(dto);
        }
    }
}
