using Repository.Concrete.EntityFramework;
using Repository.Contracts;

namespace Repository.Concrete
{
    public class RealEstateValueTypesRepository : RepositoryBase<Entity.Models.ValueType>, IRealEstateValueTypesRepository
    {
        public RealEstateValueTypesRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
