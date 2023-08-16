using AutoMapper;
using Entity.Dtos.RealEstateManagement.EstateTypes;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateTypesService : BaseService<EstateTypes, EstateTypesDto>, IRealEstateTypesService
    {
        public RealEstateTypesService(IRealEstateTypesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
