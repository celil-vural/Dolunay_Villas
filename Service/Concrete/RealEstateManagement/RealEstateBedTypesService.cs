using AutoMapper;
using Entity.Dtos.RealEstateManagement.BedTypes;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateBedTypesService : BaseService<BedTypes, BedTypesDto>, IRealEstateBedTypesService
    {
        public RealEstateBedTypesService(IRealEstateBedTypesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        { }
    }
}
