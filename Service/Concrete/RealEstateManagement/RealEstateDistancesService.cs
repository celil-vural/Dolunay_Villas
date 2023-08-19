using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.Distances;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.Distances;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateDistancesService : BaseService<Distances, DistancesDto>, IRealEstateDistancesService
    {
        public RealEstateDistancesService(IRealEstateDistancesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }

        [FluentValidationAspect(typeof(RealEstateDistancesValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(RealEstateDistancesValidator))]
        public override void Update(DistancesDto dto)
        {
            base.Update(dto);
        }
    }
}
