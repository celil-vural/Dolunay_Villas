using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.RealEstateFeatures;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.EstateFeatures;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateFeaturesService : BaseService<RealEstateFeatures, RealEstateFeaturesDto, RealEstateFeaturesDtoForInsertion, RealEstateFeaturesDtoForUpdate>, IRealEstateFeaturesService
    {
        public RealEstateFeaturesService(IRealEstateFeaturesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
        [FluentValidationAspect(typeof(RealEstateFeaturesInsertionValidator))]
        public override int CreateWithDto(RealEstateFeaturesDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(RealEstateFeaturesUpdateValidator))]
        public override void Update(RealEstateFeaturesDto dto)
        {
            base.Update(dto);
        }
    }
}
