using AutoMapper;
using Entity.Dtos.RealEstateManagement.ItemTypes;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateItemTypesService : BaseService<ItemTypes, ItemTypeDto>, IRealEstateItemTypesService
    {
        public RealEstateItemTypesService(IRealEstateItemTypesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
