using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;
using ValueType = Entity.Models.RealEstateManagement.ValueType.ValueType;
namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateValueTypesRepository : RepositoryBase<ValueType>, IRealEstateValueTypesRepository
    {
        public RealEstateValueTypesRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
