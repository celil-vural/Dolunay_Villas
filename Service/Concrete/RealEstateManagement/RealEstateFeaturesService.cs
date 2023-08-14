using AutoMapper;
using Entity.Dtos.RealEstateManagement.RealEstateFeatures;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateFeaturesService : BaseService<RealEstateFeatures, RealEstateFeaturesDto>, IRealEstateFeaturesService
    {
        public RealEstateFeaturesService(IRealEstateFeaturesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
