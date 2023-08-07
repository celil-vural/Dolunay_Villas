using AutoMapper;
using Entity.Dtos.RealEstateManagement.Rooms;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateRoomsService : BaseService<Rooms, RoomsDto>, IRealEstateRoomsService
    {

        public RealEstateRoomsService(IRealEstateRoomsRepository realEstateRoomsRepository, IMapper mapper) : base(realEstateRoomsRepository, mapper)
        {
        }
    }
}
