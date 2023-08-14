using AutoMapper;
using Entity.Dtos.RealEstateManagement.PropertyProperties;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstatePropertyPropertiesService : BaseService<PropertyProperties, PropertyPropertiesDto>, IRealEstatePropertyPropertiesService
    {
        public RealEstatePropertyPropertiesService(IRealEstatePropertyPropertiesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
