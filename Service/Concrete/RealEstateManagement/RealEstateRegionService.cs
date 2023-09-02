using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.Region;
using Entity.Models.RealEstateManagement.Regions;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.Region;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateRegionService : BaseService<Region, RegionDto>, IRealEstateRegionService
    {
        public RealEstateRegionService(IRealEstateRegionRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }

        [FluentValidationAspect(typeof(RealEstateRegionValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(RealEstateRegionValidator))]
        public override void Update(RegionDto dto)
        {
            base.Update(dto);
        }
    }
}
