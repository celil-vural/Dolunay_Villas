using AutoMapper;
using Entity.Models;
using Repository.Contracts;
using Service.Contract;

namespace Service.Concrete
{
    public class RealEstateItemTypesService : BaseService<ItemTypes>, IRealEstateItemTypesService
    {
        public RealEstateItemTypesService(IRepositoryBase<ItemTypes> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
