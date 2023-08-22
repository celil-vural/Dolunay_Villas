using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.DistanceRuler;
using Entity.Models.RealEstateManagement.DistanceRuler;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.DistanceRuler;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateDistanceRulerService : BaseService<DistanceRuler, DistanceRulerDto>, IRealEstateDistanceRulerService
    {
        public RealEstateDistanceRulerService(IRealEstateDistanceRulerRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
        [FluentValidationAspect(typeof(RealEstateDistanceRulerValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(RealEstateDistanceRulerValidator))]
        public override void Update(DistanceRulerDto dto)
        {
            base.Update(dto);
        }
    }
}
