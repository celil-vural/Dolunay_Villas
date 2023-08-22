using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.RoomFeatures;
using Entity.Models.RealEstateManagement.RoomFeature;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.RoomFeatures;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateRoomFeaturesService : BaseService<RoomFeatures, RoomFeaturesDto>, IRealEstateRoomFeaturesService
    {
        public RealEstateRoomFeaturesService(IMapper mapper, IRealEstateRoomFeaturesRepository realEstateRoomFeaturesRepository) : base(realEstateRoomFeaturesRepository, mapper)
        {
        }

        [FluentValidationAspect(typeof(RealEstateRoomFeaturesValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }

        [FluentValidationAspect(typeof(RealEstateRoomFeaturesValidator))]
        public override void Update(RoomFeaturesDto dto)
        {
            base.Update(dto);
        }
    }
}
