using AutoMapper;
using Entity.Dtos.RealEstateManagement.Region;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateRegionService : BaseService<Region, RegionDto>, IRealEstateRegionService
    {
        public RealEstateRegionService(IRealEstateRegionRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
