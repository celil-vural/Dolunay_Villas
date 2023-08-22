using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.ItemTypes;
using Entity.Models.RealEstateManagement.ItemType;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.ItemTypes;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateItemTypesService : BaseService<ItemTypes, ItemTypeDto>, IRealEstateItemTypesService
    {
        public RealEstateItemTypesService(IRealEstateItemTypesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }


        [FluentValidationAspect(typeof(RealEstateItemTypesValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }

        [FluentValidationAspect(typeof(RealEstateItemTypesValidator))]
        public override void Update(ItemTypeDto dto)
        {
            base.Update(dto);
        }
    }
}