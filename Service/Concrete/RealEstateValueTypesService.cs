using AutoMapper;
using Repository.Contracts;
using Service.Contract;
using ValueType = Entity.Models.ValueType;

namespace Service.Concrete
{
    public class RealEstateValueTypesService : BaseService<ValueType>, IRealEstateValueTypesService
    {
        public RealEstateValueTypesService(IRepositoryBase<ValueType> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
