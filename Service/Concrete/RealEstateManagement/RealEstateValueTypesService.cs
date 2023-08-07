using AutoMapper;
using Entity.Dtos.RealEstateManagement.ValueTypes;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using ValueType = Entity.Models.RealEstateManagement.ValueType;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateValueTypesService : BaseService<ValueType, ValueTypeDto>, IRealEstateValueTypesService
    {
        public RealEstateValueTypesService(IRealEstateValueTypesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
