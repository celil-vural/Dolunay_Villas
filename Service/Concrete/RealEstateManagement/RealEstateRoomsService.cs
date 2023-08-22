using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.Rooms;
using Entity.Models.RealEstateManagement.Room;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.Rooms;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateRoomsService : BaseService<Rooms, RoomsDto>, IRealEstateRoomsService
    {

        public RealEstateRoomsService(IRealEstateRoomsRepository realEstateRoomsRepository, IMapper mapper) : base(realEstateRoomsRepository, mapper)
        {
        }

        [FluentValidationAspect(typeof(RealEstateRoomsValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }

        [FluentValidationAspect(typeof(RealEstateRoomsValidator))]
        public override void Update(RoomsDto dto)
        {
            base.Update(dto);
        }
    }
}
