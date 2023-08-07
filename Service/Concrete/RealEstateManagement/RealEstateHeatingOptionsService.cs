using AutoMapper;
using Entity.Dtos.RealEstateManagement.HeatingOptions;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateHeatingOptionsService : BaseService<HeatingOptions, HeatingOptionsDto>, IRealEstateHeatingOptionsService
    {
        public RealEstateHeatingOptionsService(IRealEstateHeatingOptionsRepository realEstateHeatingOptionsRepository, IMapper mapper) : base(realEstateHeatingOptionsRepository, mapper) { }
    }
}
